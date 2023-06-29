// <summary>
// <copyright file="UpdateUserInputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.UpdateUser;

/// <summary>
/// Update User Input Port Class.
/// </summary>
public class UpdateUserInputPort : IInputPort<UpdateUserDto, bool>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateUserInputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public UpdateUserInputPort(
        UpdateUserDto data, IOutputPort<bool> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public UpdateUserDto Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<bool> OutputPort { get; private set; }
}
