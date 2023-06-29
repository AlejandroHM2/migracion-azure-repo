// <summary>
// <copyright file="Update[%= name %]InputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.Update[%= name %];

/// <summary>
/// Update [%= name %] Input Port Class.
/// </summary>
public class Update[%= name %]InputPort : IInputPort<Update[%= name %]Dto, bool>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Update[%= name %]InputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public Update[%= name %]InputPort(
        Update[%= name %]Dto data, IOutputPort<bool> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public Update[%= name %]Dto Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<bool> OutputPort { get; private set; }
}
