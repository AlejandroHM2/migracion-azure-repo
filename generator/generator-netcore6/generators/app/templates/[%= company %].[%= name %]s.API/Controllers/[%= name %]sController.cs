// <summary>
// <copyright file="[%= name %]sController.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.API.Controllers;

/// <summary>
/// [%= name %]s Controller Class.
/// </summary>
[Route("api/[%= name_lower %]s")]
[ApiController]
public class [%= name %]sController : ControllerBase
{
    /// <summary>
    /// MediatR property.
    /// </summary>
    private readonly IMediator mediator;

    /// <summary>
    /// Initializes a new instance of the <see cref="[%= name %]sController"/> class.
    /// </summary>
    /// <param name="mediator">Property MediatR Injected.</param>
    public [%= name %]sController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Get All [%= name %]s.
    /// </summary>
    /// <returns>List of [%= name %] objects.</returns>
    [HttpGet]
    public async Task<IEnumerable<[%= name %]Dto>> Get()
    {
        GetAll[%= name %]sPresenter presenter = new ();
        await this.mediator.Send(new GetAll[%= name %]InputPort(presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Get [%= name %] By Id.
    /// </summary>
    /// <param name="id">[%= name %] id.</param>
    /// <returns>[%= name %] object.</returns>
    [HttpGet("{id}")]
    public async Task<[%= name %]Dto> Get(int id)
    {
        Get[%= name %]ByIdPresenter presenter = new ();
        await this.mediator.Send(new Get[%= name %]ByIdInputPort(id, presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Get [%= name %] By Id.
    /// </summary>
    /// <param name="[%= name_lower %]">Object to Create [%= name %].</param>
    /// <returns>Id [%= name %].</returns>
    [HttpPost]
    public async Task<string> CreateAsync(Create[%= name %]Dto [%= name_lower %])
    {
        Create[%= name %]Presenter presenter = new ();
        await this.mediator.Send(new Create[%= name %]InputPort([%= name_lower %], presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Update [%= name %].
    /// </summary>
    /// <param name="[%= name_lower %]">Object to Update [%= name %].</param>
    /// <returns>Status of Updated.</returns>
    [HttpPut("{id}")]
    public async Task<string> Put(Update[%= name %]Dto [%= name_lower %])
    {
        Update[%= name %]Presenter presenter = new ();
        await this.mediator.Send(new Update[%= name %]InputPort([%= name_lower %], presenter));
        return presenter.Content;
    }

    /// <summary>
    /// Delete [%= name %].
    /// </summary>
    /// <param name="id">Object to Delete [%= name %].</param>
    /// <returns>Status of Deleted.</returns>
    [HttpDelete("{id}")]
    public async Task<string> Delete(long id)
    {
        Delete[%= name %]Presenter presenter = new ();
        await this.mediator.Send(new Delete[%= name %]InputPort(id, presenter));
        return presenter.Content;
    }
}
