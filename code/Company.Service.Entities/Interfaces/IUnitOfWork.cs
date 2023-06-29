// <summary>
// <copyright file="IUnitOfWork.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Entities.Interfaces;

/// <summary>
/// Unit Of Work Interface.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Gets User Repository.
    /// </summary>
    /// <value>
    /// User Repository.
    /// </value>
    IUserRepository Users { get; }

    /// <summary>
    /// Gets User Detail Repository.
    /// </summary>
    /// <value>
    /// User Detail Repository.
    /// </value>
    IUserDetailRepository UserDetails { get; }
}
