// <summary>
// <copyright file="DeleteUserInputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.DeleteUser;

/// <summary>
/// Delete User Input Port Class.
/// </summary>
public class DeleteUserInputPort : IInputPort<long, long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteUserInputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public DeleteUserInputPort(
        long data, IOutputPort<long> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public long Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<long> OutputPort { get; private set; }
}
