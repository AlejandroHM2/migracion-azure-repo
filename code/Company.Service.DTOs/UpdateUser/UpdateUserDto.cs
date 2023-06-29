// <summary>
// <copyright file="UpdateUserDto.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.DTOs.UpdateUser;

/// <summary>
/// Update User Class.
/// </summary>
public class UpdateUserDto : UserDto
{
    /// <summary>
    /// Gets or sets property Creation Date.
    /// </summary>
    /// <value>
    /// Property Creation Date.
    /// </value>
    public DateTime CreationDate { get; set; }
}
