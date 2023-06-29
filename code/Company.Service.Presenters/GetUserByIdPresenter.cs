// <summary>
// <copyright file="GetUserByIdPresenter.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Presenters;

/// <summary>
/// Get User By Id Presenter Class.
/// </summary>
public class GetUserByIdPresenter : IPresenter<UserDto, UserDto>
{
    /// <inheritdoc/>
    public UserDto Content { get; private set; }

    /// <inheritdoc/>
    public void Handle(UserDto response)
    {
        this.Content = response;
    }
}
