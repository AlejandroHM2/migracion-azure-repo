// <summary>
// <copyright file="IInputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Common.Ports;

/// <summary>
/// InputPort Interface.
/// </summary>
/// <typeparam name="TInteractorRequestType">Request Type.</typeparam>
/// <typeparam name="TInteractorResponseType">Response Type.</typeparam>
public interface IInputPort<TInteractorRequestType, TInteractorResponseType>
    : IRequest
{
    /// <summary>
    /// Gets property Data.
    /// </summary>
    /// <value>
    /// Property Data.
    /// </value>
    TInteractorRequestType Data { get; }

    /// <summary>
    /// Gets Output Port.
    /// </summary>
    /// <value>
    /// Output Port.
    /// </value>
    IOutputPort<TInteractorResponseType> OutputPort { get; }
}

/// <summary>
/// InputPort Interface.
/// </summary>
/// <typeparam name="TInteractorResponseType">Response Type.</typeparam>
public interface IInputPort<TInteractorResponseType>
    : IRequest
{
    /// <summary>
    /// Gets Output Port.
    /// </summary>
    /// <value>
    /// Output Port.
    /// </value>
    IOutputPort<TInteractorResponseType> OutputPort { get; }
}
