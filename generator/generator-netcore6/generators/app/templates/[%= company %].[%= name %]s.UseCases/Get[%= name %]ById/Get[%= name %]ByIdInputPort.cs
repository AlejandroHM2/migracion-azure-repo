// <summary>
// <copyright file="Get[%= name %]ByIdInputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.GetById[%= name %];

/// <summary>
/// Get [%= name %] By Id InputPort Class.
/// </summary>
public class Get[%= name %]ByIdInputPort : IInputPort<int, [%= name %]Dto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Get[%= name %]ByIdInputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public Get[%= name %]ByIdInputPort(
        int data, IOutputPort<[%= name %]Dto> outputPort) =>
        (this.Data, this.OutputPort) = (data, outputPort);

    /// <inheritdoc/>
    public int Data { get; private set; }

    /// <inheritdoc/>
    public IOutputPort<[%= name %]Dto> OutputPort { get; private set; }
}
