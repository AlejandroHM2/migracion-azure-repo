// <summary>
// <copyright file="GetAll[%= name %]sPresenter.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Presenters;

/// <summary>
/// Get All [%= name %]s Presenter Class.
/// </summary>
public class GetAll[%= name %]sPresenter : IPresenter<IEnumerable<[%= name %]Dto>, IEnumerable<[%= name %]Dto>>
{
    /// <inheritdoc/>
    public IEnumerable<[%= name %]Dto> Content { get; private set; }

    /// <inheritdoc/>
    public void Handle(IEnumerable<[%= name %]Dto> response)
    {
        this.Content = response;
    }
}
