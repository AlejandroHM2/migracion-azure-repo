// <summary>
// <copyright file="User.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Entities.Poco;

/// <summary>
/// User Class.
/// </summary>
[Table("tbl_user")]
public class User
{
    /// <summary>
    /// Gets or Sets User Id.
    /// </summary>
    /// <value>
    /// User Id.
    /// </value>
    [Key]
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or Sets User Name.
    /// </summary>
    /// <value>
    /// User Name.
    /// </value>
    [Column("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets User Last Name.
    /// </summary>
    /// <value>
    /// User Last Name.
    /// </value>
    [Column("lastname")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets User Email.
    /// </summary>
    /// <value>
    /// User Email.
    /// </value>
    [Column("email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets User Type.
    /// </summary>
    /// <value>
    /// User Type.
    /// </value>
    [Column("usertype")]
    public UserType UserType { get; set; }
}
