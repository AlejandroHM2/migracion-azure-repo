// <summary>
// <copyright file="IUnitOfWork.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Entities.Interfaces;

/// <summary>
/// Unit Of Work Interface.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Gets [%= name %] Repository.
    /// </summary>
    /// <value>
    /// [%= name %] Repository.
    /// </value>
    I[%= name %]Repository [%= name %]s { get; }

    /// <summary>
    /// Gets [%= name %] Detail Repository.
    /// </summary>
    /// <value>
    /// [%= name %] Detail Repository.
    /// </value>
    I[%= name %]DetailRepository [%= name %]Details { get; }
}
