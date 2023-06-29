// <summary>
// <copyright file="Delete[%= name %]Interactor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Delete[%= name %];

/// <summary>
/// Delete [%= name %] Interactor Class.
/// </summary>
public class Delete[%= name %]Interactor : IRequestHandler<Delete[%= name %]InputPort>
{
    private readonly IUnitOfWork unitOfWork;

    /// <summary>
    /// Initializes a new instance of the <see cref="Delete[%= name %]Interactor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit Of Work.</param>
    public Delete[%= name %]Interactor(
        IUnitOfWork unitOfWork) =>
        this.unitOfWork =
        unitOfWork;

    /// <inheritdoc/>
    public async Task Handle(Delete[%= name %]InputPort request, CancellationToken cancellationToken)
    {
        try
        {
            await this.unitOfWork.[%= name %]s.Delete(request.Data);
        }
        catch (Exception ex)
        {
            throw new GeneralException(
                "Error al crear la entidad",
                ex.Message);
        }

        request.OutputPort.Handle(request.Data);
    }
}
