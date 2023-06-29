// <summary>
// <copyright file="[%= name %]Detail.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Entities.Poco;

/// <summary>
/// [%= name %] Detail Class.
/// </summary>
[Table("tbl_[%= name_lower %]_detail")]
public class [%= name %]Detail
{
    /// <summary>
    /// Gets or Sets [%= name %] Detail Id.
    /// </summary>
    /// <value>
    /// [%= name %] Detail Id.
    /// </value>
    [Key]
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or Sets [%= name %] Id.
    /// </summary>
    /// <value>
    /// [%= name %] Id.
    /// </value>
    [Column("[%= name_lower %]id")]
    public long [%= name %]Id { get; set; }

    /// <summary>
    /// Gets or Sets [%= name %] Detail Description.
    /// </summary>
    /// <value>
    /// [%= name %] Detail Description.
    /// </value>
    [Column("description")]
    public string Description { get; set; }
}
