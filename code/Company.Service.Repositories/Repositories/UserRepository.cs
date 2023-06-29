// <summary>
// <copyright file="UserRepository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Repositories.Repositories;

/// <summary>
/// User Repository Class.
/// </summary>
public class UserRepository : IUserRepository
{
    private readonly IDataBaseContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserRepository"/> class.
    /// </summary>
    /// <param name="context">Data Base Context.</param>
    public UserRepository(IDataBaseContext context) => this.context = context;

    /// <inheritdoc/>
    public async Task Create(User user)
    {
        using var conn = this.context.OpenConnection();
        await conn.InsertAsync(user);
    }

    /// <inheritdoc/>
    public async Task<bool> Update(User user)
    {
        using var conn = this.context.OpenConnection();
        return await conn.UpdateAsync<User>(user);
    }

    /// <inheritdoc/>
    public async Task<bool> Delete(long id)
    {
        using var conn = this.context.OpenConnection();
        return await conn.DeleteAsync(new User { Id = id });
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<User>> GetAll()
    {
        using var conn = this.context.OpenConnection();
        return await conn.FindAsync<User>();
    }

    /// <inheritdoc/>
    public async Task<User> GetById(long id)
    {
        using var conn = this.context.OpenConnection();
        return await conn.GetAsync<User>(new User { Id = id });
    }
}
