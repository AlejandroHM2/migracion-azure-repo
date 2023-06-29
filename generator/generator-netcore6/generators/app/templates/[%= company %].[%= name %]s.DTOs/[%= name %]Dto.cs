// <summary>
// <copyright file="[%= name %]Dto.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.DTOs;

/// <summary>
/// [%= name %] Class.
/// </summary>
public class [%= name %]Dto
{
    /// <summary>
    /// Gets or sets property Id.
    /// </summary>
    /// <value>
    /// Property Id.
    /// </value>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets property Name.
    /// </summary>
    /// <value>
    /// Property Name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets property Last Name.
    /// </summary>
    /// <value>
    /// Property Last Name.
    /// </value>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets property Email.
    /// </summary>
    /// <value>
    /// Property Email.
    /// </value>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets property [%= name %] Type.
    /// </summary>
    /// <value>
    /// Property [%= name %] Type.
    /// </value>
    public string [%= name %]Type { get; set; }

    /// <summary>
    /// Gets or sets list [%= name %] Details.
    /// </summary>
    /// <value>
    /// Property list [%= name %] Details.
    /// </value>
    public List<[%= name %]DetailDto> [%= name %]Details { get; set; }
}
