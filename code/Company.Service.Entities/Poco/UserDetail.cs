// <summary>
// <copyright file="UserDetail.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Entities.Poco;

/// <summary>
/// User Detail Class.
/// </summary>
[Table("tbl_user_detail")]
public class UserDetail
{
    /// <summary>
    /// Gets or Sets User Detail Id.
    /// </summary>
    /// <value>
    /// User Detail Id.
    /// </value>
    [Key]
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or Sets User Id.
    /// </summary>
    /// <value>
    /// User Id.
    /// </value>
    [Column("userid")]
    public long UserId { get; set; }

    /// <summary>
    /// Gets or Sets User Detail Description.
    /// </summary>
    /// <value>
    /// User Detail Description.
    /// </value>
    [Column("description")]
    public string Description { get; set; }
}
