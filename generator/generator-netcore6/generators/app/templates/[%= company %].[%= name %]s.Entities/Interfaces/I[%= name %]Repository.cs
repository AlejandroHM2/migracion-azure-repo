// <summary>
// <copyright file="I[%= name %]Repository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Entities.Interfaces;

/// <summary>
/// [%= name %] Repository Interface.
/// </summary>
public interface I[%= name %]Repository
{
    /// <summary>
    /// Create a [%= name %].
    /// </summary>
    /// <param name="[%= name_lower %]">[%= name %] Object.</param>
    /// <returns>Void.</returns>
    Task Create([%= name %] [%= name_lower %]);

    /// <summary>
    /// Update a [%= name %].
    /// </summary>
    /// <param name="[%= name_lower %]">[%= name %] Object.</param>
    /// <returns>Status Updated.</returns>
    Task<bool> Update([%= name %] [%= name_lower %]);

    /// <summary>
    /// Delete a [%= name %].
    /// </summary>
    /// <param name="id">[%= name %] Id.</param>
    /// <returns>Status Deleted.</returns>
    Task<bool> Delete(long id);

    /// <summary>
    /// Get All [%= name %]s.
    /// </summary>
    /// <returns>List of [%= name %]s.</returns>
    Task<IEnumerable<[%= name %]>> GetAll();

    /// <summary>
    /// Get [%= name %] By Id.
    /// </summary>
    /// <param name="id">[%= name %] Id.</param>
    /// <returns>[%= name %] Object.</returns>
    Task<[%= name %]> GetById(long id);
}
