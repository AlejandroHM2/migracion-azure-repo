// <summary>
// <copyright file="UnitOfWork.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Repositories.Repositories;

/// <summary>
/// Unit Of Work Class.
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
    /// </summary>
    /// <param name="users">User Repository.</param>
    /// <param name="userDetails">User Detail Repository.</param>
    public UnitOfWork(IUserRepository users, IUserDetailRepository userDetails)
    {
        this.Users = users;
        this.UserDetails = userDetails;
    }

    /// <inheritdoc/>
    public IUserRepository Users { get; }

    /// <inheritdoc/>
    public IUserDetailRepository UserDetails { get; }
}
