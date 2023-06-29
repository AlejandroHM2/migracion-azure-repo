// <summary>
// <copyright file="CreateUserInputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.UseCases.CreateUser;

/// <summary>
/// CreateUser Input Port Class.
/// </summary>
public class CreateUserInputPort : IInputPort<CreateUserDto, long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateUserInputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public CreateUserInputPort(
        CreateUserDto data, IOutputPort<long> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public CreateUserDto Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<long> OutputPort { get; private set; }
}
