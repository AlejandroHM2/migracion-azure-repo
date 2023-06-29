// <summary>
// <copyright file="[%= name %]DetailDto.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.DTOs;

/// <summary>
/// [%= name %] Detail Class.
/// </summary>
public class [%= name %]DetailDto
{
    /// <summary>
    /// Gets or sets property Id.
    /// </summary>
    /// <value>
    /// Property Id.
    /// </value>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets property [%= name %] Id.
    /// </summary>
    /// <value>
    /// Property [%= name %] Id.
    /// </value>
    public long [%= name %]Id { get; set; }

    /// <summary>
    /// Gets or sets property Description.
    /// </summary>
    /// <value>
    /// Property Description.
    /// </value>
    public string Description { get; set; }
}
