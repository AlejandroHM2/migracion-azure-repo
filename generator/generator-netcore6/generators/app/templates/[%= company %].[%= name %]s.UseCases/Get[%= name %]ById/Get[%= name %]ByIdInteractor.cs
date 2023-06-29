// <summary>
// <copyright file="Get[%= name %]ByIdInteractor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.GetById[%= name %];

/// <summary>
/// Get [%= name %] By Id Interactor Class.
/// </summary>
public class Get[%= name %]ByIdInteractor : IRequestHandler<Get[%= name %]ByIdInputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly IDistributedCache cache;

    /// <summary>
    /// Initializes a new instance of the <see cref="Get[%= name %]ByIdInteractor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit Of Work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    /// <param name="cache">Distributed Cache.</param>
    public Get[%= name %]ByIdInteractor(
        IUnitOfWork unitOfWork, IMapper mapper, IDistributedCache cache) =>
        (this.unitOfWork, this.mapper, this.cache) =
        (unitOfWork, mapper, cache);

    /// <inheritdoc/>
    public async Task Handle(Get[%= name %]ByIdInputPort request, CancellationToken cancellationToken)
    {
        [%= name %]Dto [%= name_lower %];

        var cacheResult = await this.cache.GetStringAsync(request.Data.ToString());
        if (!string.IsNullOrEmpty(cacheResult))
        {
            [%= name_lower %] = JsonConvert.DeserializeObject<[%= name %]Dto>(cacheResult);
        }
        else
        {
            [%= name_lower %] = this.mapper.Map<[%= name %]Dto>(await this.unitOfWork.[%= name %]s.GetById(request.Data));

            if ([%= name_lower %] != null)
            {
                await this.cache.SetStringAsync(request.Data.ToString(), JsonConvert.SerializeObject([%= name_lower %]), new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10),
                });
            }
        }

        request.OutputPort.Handle([%= name_lower %]);
    }
}
