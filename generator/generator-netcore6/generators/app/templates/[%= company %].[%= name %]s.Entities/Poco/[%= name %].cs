// <summary>
// <copyright file="[%= name %].cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Entities.Poco;

/// <summary>
/// [%= name %] Class.
/// </summary>
[Table("tbl_[%= name_lower %]")]
public class [%= name %]
{
    /// <summary>
    /// Gets or Sets [%= name %] Id.
    /// </summary>
    /// <value>
    /// [%= name %] Id.
    /// </value>
    [Key]
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or Sets [%= name %] Name.
    /// </summary>
    /// <value>
    /// [%= name %] Name.
    /// </value>
    [Column("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets [%= name %] Last Name.
    /// </summary>
    /// <value>
    /// [%= name %] Last Name.
    /// </value>
    [Column("lastname")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets [%= name %] Email.
    /// </summary>
    /// <value>
    /// [%= name %] Email.
    /// </value>
    [Column("email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets [%= name %] Type.
    /// </summary>
    /// <value>
    /// [%= name %] Type.
    /// </value>
    [Column("[%= name_lower %]type")]
    public [%= name %]Type [%= name %]Type { get; set; }
}
