// <summary>
// <copyright file="GetUserByIdInputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.GetByIdUser;

/// <summary>
/// Get User By Id InputPort Class.
/// </summary>
public class GetUserByIdInputPort : IInputPort<int, UserDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetUserByIdInputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public GetUserByIdInputPort(
        int data, IOutputPort<UserDto> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public int Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<UserDto> OutputPort { get; private set; }
}
