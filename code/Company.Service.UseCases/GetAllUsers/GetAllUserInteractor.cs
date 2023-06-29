// <summary>
// <copyright file="GetAllUserInteractor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.GetAllUsers;

/// <summary>
/// Get All User Interactor Class.
/// </summary>
public class GetAllUserInteractor : IRequestHandler<GetAllUserInputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly IDistributedCache cache;

    /// <summary>
    /// Initializes a new instance of the <see cref="GetAllUserInteractor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit of work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    /// <param name="cache">Distributed Cache.</param>
    public GetAllUserInteractor(
        IUnitOfWork unitOfWork, IMapper mapper, IDistributedCache cache) =>
        (this.unitOfWork, this.mapper, this.cache) =
        (unitOfWork, mapper, cache);

    /// <inheritdoc/>
    public async Task Handle(GetAllUserInputPort request, CancellationToken cancellationToken)
    {
        IEnumerable<UserDto> users;

        var cacheResult = await this.cache.GetStringAsync("ALL");
        if (!string.IsNullOrEmpty(cacheResult))
        {
            users = JsonConvert.DeserializeObject<IEnumerable<UserDto>>(cacheResult);
        }
        else
        {
            users = this.mapper.Map<IEnumerable<UserDto>>(await this.unitOfWork.Users.GetAll());

            if (users.Any())
            {
                await this.cache.SetStringAsync("ALL", JsonConvert.SerializeObject(users), new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10),
                });
            }
        }

        request.OutputPort.Handle(users);
    }
}
