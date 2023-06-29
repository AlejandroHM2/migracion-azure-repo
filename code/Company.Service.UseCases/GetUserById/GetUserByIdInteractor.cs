// <summary>
// <copyright file="GetUserByIdInteractor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.GetByIdUser;

/// <summary>
/// Get User By Id Interactor Class.
/// </summary>
public class GetUserByIdInteractor : IRequestHandler<GetUserByIdInputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly IDistributedCache cache;

    /// <summary>
    /// Initializes a new instance of the <see cref="GetUserByIdInteractor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit Of Work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    /// <param name="cache">Distributed Cache.</param>
    public GetUserByIdInteractor(
        IUnitOfWork unitOfWork, IMapper mapper, IDistributedCache cache) =>
        (this.unitOfWork, this.mapper, this.cache) =
        (unitOfWork, mapper, cache);

    /// <inheritdoc/>
    public async Task Handle(GetUserByIdInputPort request, CancellationToken cancellationToken)
    {
        UserDto user;

        var cacheResult = await this.cache.GetStringAsync(request.Data.ToString());
        if (!string.IsNullOrEmpty(cacheResult))
        {
            user = JsonConvert.DeserializeObject<UserDto>(cacheResult);
        }
        else
        {
            user = this.mapper.Map<UserDto>(await this.unitOfWork.Users.GetById(request.Data));

            if (user != null)
            {
                await this.cache.SetStringAsync(request.Data.ToString(), JsonConvert.SerializeObject(user), new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10),
                });
            }
        }

        request.OutputPort.Handle(user);
    }
}
