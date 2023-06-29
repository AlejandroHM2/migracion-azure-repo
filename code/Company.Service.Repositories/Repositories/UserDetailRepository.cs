// <summary>
// <copyright file="UserDetailRepository.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Repositories.Repositories;

/// <summary>
/// User Detail Repository Class.
/// </summary>
public class UserDetailRepository : IUserDetailRepository
{
    private readonly IDataBaseContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserDetailRepository"/> class.
    /// </summary>
    /// <param name="context">Data Base Context to Use.</param>
    public UserDetailRepository(IDataBaseContext context)
        => this.context = context;

    /// <inheritdoc/>
    public async Task Create(UserDetail userDetail)
    {
        using var conn = this.context.OpenConnection();
        await conn.InsertAsync(userDetail);
    }

    /// <inheritdoc/>
    public async Task<bool> Update(UserDetail userDetail)
    {
        using var conn = this.context.OpenConnection();
        return await conn.UpdateAsync<UserDetail>(userDetail);
    }
}
