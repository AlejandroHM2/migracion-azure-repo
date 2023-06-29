// <summary>
// <copyright file="Create[%= name %]Interactor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Create[%= name %];

/// <summary>
/// Create[%= name %] Input Port Class.
/// </summary>
public class Create[%= name %]Interactor : IRequestHandler<Create[%= name %]InputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="Create[%= name %]Interactor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit of Work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    public Create[%= name %]Interactor(
        IUnitOfWork unitOfWork, IMapper mapper) =>
        (this.unitOfWork, this.mapper) =
        (unitOfWork, mapper);

    /// <inheritdoc/>
    public async Task Handle(Create[%= name %]InputPort request, CancellationToken cancellationToken)
    {
        long id;
        try
        {
            [%= name %] [%= name_lower %] = this.mapper.Map<[%= name %]>(request.Data);
            await this.unitOfWork.[%= name %]s.Create([%= name_lower %]);
            foreach (var detail in request.Data.[%= name %]Details)
            {
                await this.unitOfWork.[%= name %]Details.Create(this.mapper.Map<[%= name %]Detail>(detail));
            }
        }
        catch (Exception ex)
        {
            throw new GeneralException(
                "Error al crear la entidad",
                ex.Message);
        }

        request.OutputPort.Handle(request.Data.Id);
    }
}
