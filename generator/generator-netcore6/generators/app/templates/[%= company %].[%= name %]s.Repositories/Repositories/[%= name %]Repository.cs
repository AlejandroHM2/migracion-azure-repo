// <summary>
// <copyright file="[%= name %]Repository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Repositories.Repositories;

/// <summary>
/// [%= name %] Repository Class.
/// </summary>
public class [%= name %]Repository : I[%= name %]Repository
{
    private readonly IDataBaseContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="[%= name %]Repository"/> class.
    /// </summary>
    /// <param name="context">Data Base Context.</param>
    public [%= name %]Repository(IDataBaseContext context) => this.context = context;

    /// <inheritdoc/>
    public async Task Create([%= name %] [%= name_lower %])
    {
        using var conn = this.context.OpenConnection();
        await conn.InsertAsync([%= name_lower %]);
    }

    /// <inheritdoc/>
    public async Task<bool> Update([%= name %] [%= name_lower %])
    {
        using var conn = this.context.OpenConnection();
        return await conn.UpdateAsync<[%= name %]>([%= name_lower %]);
    }

    /// <inheritdoc/>
    public async Task<bool> Delete(long id)
    {
        using var conn = this.context.OpenConnection();
        return await conn.DeleteAsync(new [%= name %] { Id = id });
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<[%= name %]>> GetAll()
    {
        using var conn = this.context.OpenConnection();
        return await conn.FindAsync<[%= name %]>();
    }

    /// <inheritdoc/>
    public async Task<[%= name %]> GetById(long id)
    {
        using var conn = this.context.OpenConnection();
        return await conn.GetAsync<[%= name %]>(new [%= name %] { Id = id });
    }
}
