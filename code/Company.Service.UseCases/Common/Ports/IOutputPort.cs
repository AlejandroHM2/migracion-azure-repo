// <summary>
// <copyright file="IOutputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.Common.Ports;

/// <summary>
/// OutputPort Interface.
/// </summary>
/// <typeparam name="TInteractorResponseType">Response Type.</typeparam>
public interface IOutputPort<TInteractorResponseType>
{
    /// <summary>
    /// Handler for output.
    /// </summary>
    /// <param name="response">Response Type.</param>
    void Handle(TInteractorResponseType response);
}
