// <summary>
// <copyright file="CreateUserInteractor.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.CreateUser;

/// <summary>
/// CreateUser Input Port Class.
/// </summary>
public class CreateUserInteractor : IRequestHandler<CreateUserInputPort>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateUserInteractor"/> class.
    /// </summary>
    /// <param name="unitOfWork">Unit of Work.</param>
    /// <param name="mapper">Auto Mapper.</param>
    public CreateUserInteractor(
        IUnitOfWork unitOfWork, IMapper mapper) =>
        (this.unitOfWork, this.mapper) =
        (unitOfWork, mapper);

    /// <inheritdoc/>
    public async Task Handle(CreateUserInputPort request, CancellationToken cancellationToken)
    {
        long id;
        try
        {
            User user = this.mapper.Map<User>(request.Data);
            await this.unitOfWork.Users.Create(user);
            foreach (var detail in request.Data.UserDetails)
            {
                await this.unitOfWork.UserDetails.Create(this.mapper.Map<UserDetail>(detail));
            }
        }
        catch (Exception ex)
        {
            throw new GeneralException(
                "Error al crear el usuario",
                ex.Message);
        }

        request.OutputPort.Handle(request.Data.Id);
    }
}
