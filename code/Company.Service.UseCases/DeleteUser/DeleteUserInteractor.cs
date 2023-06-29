// <summary>
// <copyright file="DeleteUserInteractor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.DeleteUser;

/// <summary>
/// Delete User Interactor Class.
/// </summary>
public class DeleteUserInteractor : IRequestHandler<DeleteUserInputPort>
{
    private readonly IUnitOfWork unitOfWork;

    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteUserInteractor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit Of Work.</param>
    public DeleteUserInteractor(
        IUnitOfWork unitOfWork) =>
        this.unitOfWork =
        unitOfWork;

    /// <inheritdoc/>
    public async Task Handle(DeleteUserInputPort request, CancellationToken cancellationToken)
    {
        try
        {
            await this.unitOfWork.Users.Delete(request.Data);
        }
        catch (Exception ex)
        {
            throw new GeneralException(
                "Error al crear la orden",
                ex.Message);
        }

        request.OutputPort.Handle(request.Data);
    }
}
