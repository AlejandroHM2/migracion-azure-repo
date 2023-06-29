// <summary>
// <copyright file="IUserDetailRepository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Entities.Interfaces;

/// <summary>
/// User Detail Repository Interface.
/// </summary>
public interface IUserDetailRepository
{
    /// <summary>
    /// Create a User Detail.
    /// </summary>
    /// <param name="userDetail">User Detail Object.</param>
    /// <returns>Void.</returns>
    Task Create(UserDetail userDetail);

    /// <summary>
    /// Update a User Detail.
    /// </summary>
    /// <param name="userDetail">User Detail Object.</param>
    /// <returns>Status Updated.</returns>
    Task<bool> Update(UserDetail userDetail);
}
