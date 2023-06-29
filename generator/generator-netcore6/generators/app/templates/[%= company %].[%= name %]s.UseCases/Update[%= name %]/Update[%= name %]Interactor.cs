// <summary>
// <copyright file="Update[%= name %]Interactor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Update[%= name %];

/// <summary>
/// Update [%= name %] Interactor Class.
/// </summary>
public class Update[%= name %]Interactor : IRequestHandler<Update[%= name %]InputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="Update[%= name %]Interactor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit Of Work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    public Update[%= name %]Interactor(
        IUnitOfWork unitOfWork, IMapper mapper) =>
        (this.unitOfWork, this.mapper) =
        (unitOfWork, mapper);

    /// <inheritdoc/>
    public async Task Handle(Update[%= name %]InputPort request, CancellationToken cancellationToken)
    {
        bool success;

        try
        {
            [%= name %] [%= name_lower %] = this.mapper.Map<[%= name %]>(request.Data);
            success = await this.unitOfWork.[%= name %]s.Update([%= name_lower %]);

            foreach (var detail in request.Data.[%= name %]Details)
            {
                success = await this.unitOfWork.[%= name %]Details.Update(this.mapper.Map<[%= name %]Detail>(detail));
            }
        }
        catch (Exception ex)
        {
            throw new GeneralException(
                "Error al crear la entidad",
                ex.Message);
        }

        request.OutputPort.Handle(success);
    }
}
