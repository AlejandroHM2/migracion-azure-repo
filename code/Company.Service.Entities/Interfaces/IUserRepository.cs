// <summary>
// <copyright file="IUserRepository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Entities.Interfaces;

/// <summary>
/// User Repository Interface.
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Create a User.
    /// </summary>
    /// <param name="user">User Object.</param>
    /// <returns>Void.</returns>
    Task Create(User user);

    /// <summary>
    /// Update a User.
    /// </summary>
    /// <param name="user">User Object.</param>
    /// <returns>Status Updated.</returns>
    Task<bool> Update(User user);

    /// <summary>
    /// Delete a User.
    /// </summary>
    /// <param name="id">User Id.</param>
    /// <returns>Status Deleted.</returns>
    Task<bool> Delete(long id);

    /// <summary>
    /// Get All Users.
    /// </summary>
    /// <returns>List of Users.</returns>
    Task<IEnumerable<User>> GetAll();

    /// <summary>
    /// Get User By Id.
    /// </summary>
    /// <param name="id">User Id.</param>
    /// <returns>User Object.</returns>
    Task<User> GetById(long id);
}
