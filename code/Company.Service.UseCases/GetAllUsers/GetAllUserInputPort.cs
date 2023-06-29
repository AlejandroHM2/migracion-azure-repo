// <summary>
// <copyright file="GetAllUserInputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.GetAllUsers;

/// <summary>
/// Get All User InputPort Class.
/// </summary>
public class GetAllUserInputPort : IInputPort<IEnumerable<UserDto>>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetAllUserInputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public GetAllUserInputPort(
        IOutputPort<IEnumerable<UserDto>> outputPort) =>
        this.OutputPort = outputPort;

    /// <inheritdoc/>
    public IOutputPort<IEnumerable<UserDto>> OutputPort { get; private set; }
}
