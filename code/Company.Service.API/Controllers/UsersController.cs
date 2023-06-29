// <summary>
// <copyright file="UsersController.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.API.Controllers;

/// <summary>
/// Users Controller Class.
/// </summary>
[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    /// <summary>
    /// MediatR property.
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// Initializes a new instance of the <see cref="UsersController"/> class.
    /// </summary>
    /// <param name="mediator">Property MediatR Injected.</param>
    public UsersController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Get All Users.
    /// </summary>
    /// <returns>List of User objects.</returns>
    [HttpGet]
    public async Task<IEnumerable<UserDto>> Get()
    {
        GetAllUsersPresenter presenter = new ();
        await this.mediator.Send(new GetAllUserInputPort(presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Get User By Id.
    /// </summary>
    /// <param name="id">User id.</param>
    /// <returns>User object.</returns>
    [HttpGet("{id}")]
    public async Task<UserDto> Get(int id)
    {
        GetUserByIdPresenter presenter = new ();
        await this.mediator.Send(new GetUserByIdInputPort(id, presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Get User By Id.
    /// </summary>
    /// <param name="user">Object to Create User.</param>
    /// <returns>Id User.</returns>
    [HttpPost]
    public async Task<string> CreateAsync(CreateUserDto user)
    {
        CreateUserPresenter presenter = new ();
        await this.mediator.Send(new CreateUserInputPort(user, presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Update User.
    /// </summary>
    /// <param name="user">Object to Update User.</param>
    /// <returns>Status of Updated.</returns>
    [HttpPut("{id}")]
    public async Task<string> Put(UpdateUserDto user)
    {
        UpdateUserPresenter presenter = new ();
        await this.mediator.Send(new UpdateUserInputPort(user, presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Delete User.
    /// </summary>
    /// <param name="id">Object to Delete User.</param>
    /// <returns>Status of Deleted.</returns>
    [HttpDelete("{id}")]
    public async Task<string> Delete(long id)
    {
        DeleteUserPresenter presenter = new ();
        await this.mediator.Send(new DeleteUserInputPort(id, presenter));
        return presenter.Content;
    }
}
