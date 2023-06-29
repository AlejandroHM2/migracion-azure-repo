// <summary>
// <copyright file="I[%= name %]DetailRepository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Entities.Interfaces;

/// <summary>
/// [%= name %] Detail Repository Interface.
/// </summary>
public interface I[%= name %]DetailRepository
{
    /// <summary>
    /// Create a [%= name %] Detail.
    /// </summary>
    /// <param name="[%= name_lower %]Detail">[%= name %] Detail Object.</param>
    /// <returns>Void.</returns>
    Task Create([%= name %]Detail [%= name_lower %]Detail);

    /// <summary>
    /// Update a [%= name %] Detail.
    /// </summary>
    /// <param name="[%= name_lower %]Detail">[%= name %] Detail Object.</param>
    /// <returns>Status Updated.</returns>
    Task<bool> Update([%= name %]Detail [%= name_lower %]Detail);
}
