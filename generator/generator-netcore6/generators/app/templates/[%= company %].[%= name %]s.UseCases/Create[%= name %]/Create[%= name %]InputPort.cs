// <summary>
// <copyright file="Create[%= name %]InputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Create[%= name %];

/// <summary>
/// Create[%= name %] Input Port Class.
/// </summary>
public class Create[%= name %]InputPort : IInputPort<Create[%= name %]Dto, long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Create[%= name %]InputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public Create[%= name %]InputPort(
        Create[%= name %]Dto data, IOutputPort<long> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public Create[%= name %]Dto Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<long> OutputPort { get; private set; }
}
