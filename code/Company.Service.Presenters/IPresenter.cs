// <summary>
// <copyright file="IPresenter.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Presenters;

/// <summary>
/// Presenter Interface.
/// </summary>
/// <typeparam name="TResponseType">Type of Response.</typeparam>
/// <typeparam name="TFormatType">Format Type.</typeparam>
public interface IPresenter<TResponseType, TFormatType> : IOutputPort<TResponseType>
{
    /// <summary>
    /// Gets presenter Content.
    /// </summary>
    /// <value>
    /// Presenter Content.
    /// </value>
    public TFormatType Content { get; }
}
