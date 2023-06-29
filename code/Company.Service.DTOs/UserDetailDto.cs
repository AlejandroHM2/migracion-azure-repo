// <summary>
// <copyright file="UserDetailDto.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.DTOs;

/// <summary>
/// User Detail Class.
/// </summary>
public class UserDetailDto
{
    /// <summary>
    /// Gets or sets property Id.
    /// </summary>
    /// <value>
    /// Property Id.
    /// </value>
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets property User Id.
    /// </summary>
    /// <value>
    /// Property User Id.
    /// </value>
    public long UserId { get; set; }

    /// <summary>
    /// Gets or sets property Description.
    /// </summary>
    /// <value>
    /// Property Description.
    /// </value>
    public string Description { get; set; }
}
