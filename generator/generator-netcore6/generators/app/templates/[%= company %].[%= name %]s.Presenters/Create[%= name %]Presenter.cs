// <summary>
// <copyright file="Create[%= name %]Presenter.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Presenters;

/// <summary>
/// Create [%= name %] Presenter Class.
/// </summary>
public class Create[%= name %]Presenter : IPresenter<long, string>
{
    /// <inheritdoc/>
    public string Content { get; private set; }

    /// <inheritdoc/>
    public void Handle(long response)
    {
        this.Content = $"Created, [%= name %] Id: {response}";
    }
}
