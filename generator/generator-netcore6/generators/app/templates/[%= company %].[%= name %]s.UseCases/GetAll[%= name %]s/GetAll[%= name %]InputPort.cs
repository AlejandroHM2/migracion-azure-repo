// <summary>
// <copyright file="GetAll[%= name %]InputPort.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.UseCases.GetAll[%= name %]s;

/// <summary>
/// Get All [%= name %] InputPort Class.
/// </summary>
public class GetAll[%= name %]InputPort : IInputPort<IEnumerable<[%= name %]Dto>>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetAll[%= name %]InputPort"/> class.
    /// </summary>
    /// <param name="data">Request Data.</param>
    /// <param name="outputPort">Response Handler.</param>
    public GetAll[%= name %]InputPort(
        IOutputPort<IEnumerable<[%= name %]Dto>> outputPort) =>
        this.OutputPort = outputPort;

    /// <inheritdoc/>
    public IOutputPort<IEnumerable<[%= name %]Dto>> OutputPort { get; private set; }
}
