// <summary>
// <copyright file="Delete[%= name %]Presenter.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Presenters;

/// <summary>
/// Delete [%= name %] Presenter Class.
/// </summary>
public class Delete[%= name %]Presenter : IPresenter<long, string>
{
    /// <inheritdoc/>
    public string Content { get; private set; }

    /// <inheritdoc/>
    public void Handle(long response)
    {
        this.Content = $"Deleted, [%= name %] Id: {response}";
    }
}
