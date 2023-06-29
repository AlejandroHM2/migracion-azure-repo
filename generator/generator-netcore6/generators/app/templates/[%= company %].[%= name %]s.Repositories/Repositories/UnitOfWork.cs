// <summary>
// <copyright file="UnitOfWork.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Repositories.Repositories;

/// <summary>
/// Unit Of Work Class.
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
    /// </summary>
    /// <param name="[%= name_lower %]s">[%= name %] Repository.</param>
    /// <param name="[%= name_lower %]Details">[%= name %] Detail Repository.</param>
    public UnitOfWork(I[%= name %]Repository [%= name_lower %]s, I[%= name %]DetailRepository [%= name_lower %]Details)
    {
        this.[%= name %]s = [%= name_lower %]s;
        this.[%= name %]Details = [%= name_lower %]Details;
    }

    /// <inheritdoc/>
    public I[%= name %]Repository [%= name %]s { get; }

    /// <inheritdoc/>
    public I[%= name %]DetailRepository [%= name %]Details { get; }
}
