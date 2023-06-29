// <summary>
// <copyright file="GetAllUsersPresenter.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Presenters;

/// <summary>
/// Get All Users Presenter Class.
/// </summary>
public class GetAllUsersPresenter : IPresenter<IEnumerable<UserDto>, IEnumerable<UserDto>>
{
    /// <inheritdoc/>
    public IEnumerable<UserDto> Content { get; private set; }

    /// <inheritdoc/>
    public void Handle(IEnumerable<UserDto> response)
    {
        this.Content = response;
    }
}
