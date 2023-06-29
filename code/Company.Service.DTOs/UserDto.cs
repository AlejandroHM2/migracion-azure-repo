// <summary>
// <copyright file="UserDto.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.DTOs;

/// <summary>
/// User Class.
/// </summary>
public class UserDto
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
    /// Gets or sets property User Type.
    /// </summary>
    /// <value>
    /// Property User Type.
    /// </value>
    public string UserType { get; set; }

    /// <summary>
    /// Gets or sets list User Details.
    /// </summary>
    /// <value>
    /// Property list User Details.
    /// </value>
    public List<UserDetailDto> UserDetails { get; set; }
}
