// <summary>
// <copyright file="UpdateUserInteractor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.UpdateUser;

/// <summary>
/// Update User Interactor Class.
/// </summary>
public class UpdateUserInteractor : IRequestHandler<UpdateUserInputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateUserInteractor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit Of Work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    public UpdateUserInteractor(
        IUnitOfWork unitOfWork, IMapper mapper) =>
        (this.unitOfWork, this.mapper) =
        (unitOfWork, mapper);

    /// <inheritdoc/>
    public async Task Handle(UpdateUserInputPort request, CancellationToken cancellationToken)
    {
        bool success;

        try
        {
            User user = this.mapper.Map<User>(request.Data);
            success = await this.unitOfWork.Users.Update(user);

            foreach (var detail in request.Data.UserDetails)
            {
                success = await this.unitOfWork.UserDetails.Update(this.mapper.Map<UserDetail>(detail));
            }
        }
        catch (Exception ex)
        {
            throw new GeneralException(
                "Error al crear la orden",
                ex.Message);
        }

        request.OutputPort.Handle(success);
    }
}
