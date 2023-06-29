// <summary>
// <copyright file="GetAll[%= name %]Interactor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.GetAll[%= name %]s;

/// <summary>
/// Get All [%= name %] Interactor Class.
/// </summary>
public class GetAll[%= name %]Interactor : IRequestHandler<GetAll[%= name %]InputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly IDistributedCache cache;

    /// <summary>
    /// Initializes a new instance of the <see cref="GetAll[%= name %]Interactor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit of work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    /// <param name="cache">Distributed Cache.</param>
    public GetAll[%= name %]Interactor(
        IUnitOfWork unitOfWork, IMapper mapper, IDistributedCache cache) =>
        (this.unitOfWork, this.mapper, this.cache) =
        (unitOfWork, mapper, cache);

    /// <inheritdoc/>
    public async Task Handle(GetAll[%= name %]InputPort request, CancellationToken cancellationToken)
    {
        IEnumerable<[%= name %]Dto> [%= name_lower %]s;

        var cacheResult = await this.cache.GetStringAsync("ALL");
        if (!string.IsNullOrEmpty(cacheResult))
        {
            [%= name_lower %]s = JsonConvert.DeserializeObject<IEnumerable<[%= name %]Dto>>(cacheResult);
        }
        else
        {
            [%= name_lower %]s = this.mapper.Map<IEnumerable<[%= name %]Dto>>(await this.unitOfWork.[%= name %]s.GetAll());

            if ([%= name_lower %]s.Any())
            {
                await this.cache.SetStringAsync("ALL", JsonConvert.SerializeObject([%= name_lower %]s), new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10),
                });
            }
        }

        request.OutputPort.Handle([%= name_lower %]s);
    }
}
