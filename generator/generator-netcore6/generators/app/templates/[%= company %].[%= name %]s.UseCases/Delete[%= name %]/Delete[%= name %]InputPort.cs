// <summary>
// <copyright file="Delete[%= name %]InputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Delete[%= name %];

/// <summary>
/// Delete [%= name %] Input Port Class.
/// </summary>
public class Delete[%= name %]InputPort : IInputPort<long, long>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Delete[%= name %]InputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public Delete[%= name %]InputPort(
        long data, IOutputPort<long> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public long Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<long> OutputPort { get; private set; }
}
