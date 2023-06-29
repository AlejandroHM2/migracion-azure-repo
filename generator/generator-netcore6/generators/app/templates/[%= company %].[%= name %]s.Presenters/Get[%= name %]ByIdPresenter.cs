// <summary>
// <copyright file="Get[%= name %]ByIdPresenter.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Presenters;

/// <summary>
/// Get [%= name %] By Id Presenter Class.
/// </summary>
public class Get[%= name %]ByIdPresenter : IPresenter<[%= name %]Dto, [%= name %]Dto>
{
    /// <inheritdoc/>
    public [%= name %]Dto Content { get; private set; }

    /// <inheritdoc/>
    public void Handle([%= name %]Dto response)
    {
        this.Content = response;
    }
}
