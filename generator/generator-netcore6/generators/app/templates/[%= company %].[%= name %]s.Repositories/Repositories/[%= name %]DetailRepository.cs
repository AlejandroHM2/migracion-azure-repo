// <summary>
// <copyright file="[%= name %]DetailRepository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Repositories.Repositories;

/// <summary>
/// [%= name %] Detail Repository Class.
/// </summary>
public class [%= name %]DetailRepository : I[%= name %]DetailRepository
{
    private readonly IDataBaseContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="[%= name %]DetailRepository"/> class.
    /// </summary>
    /// <param name="context">Data Base Context to Use.</param>
    public [%= name %]DetailRepository(IDataBaseContext context)
        => this.context = context;

    /// <inheritdoc/>
    public async Task Create([%= name %]Detail [%= name_lower %]Detail)
    {
        using var conn = this.context.OpenConnection();
        await conn.InsertAsync([%= name_lower %]Detail);
    }

    /// <inheritdoc/>
    public async Task<bool> Update([%= name %]Detail [%= name_lower %]Detail)
    {
        using var conn = this.context.OpenConnection();
        return await conn.UpdateAsync<[%= name %]Detail>([%= name_lower %]Detail);
    }
}
