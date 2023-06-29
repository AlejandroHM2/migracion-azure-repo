// <summary>
// <copyright file="UserContext.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Repositories.DataContext;

/// <summary>
/// User Context Class.
/// </summary>
public class UserContext : IDataBaseContext
{
    private readonly EndpointSettings endpointSettings;
    private readonly bool inMemory;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserContext"/> class.
    /// </summary>
    /// <param name="endpointSettings">Config endpoint settings.</param>
    /// <param name="inMemory">Use Data Base in Memory.</param>
    public UserContext(IOptions<EndpointSettings> endpointSettings, bool inMemory = false)
    {
        this.endpointSettings = endpointSettings.Value;
        this.inMemory = inMemory;
    }

    /// <inheritdoc/>
    public IDbConnection OpenConnection()
    {
        OrmConfiguration.DefaultDialect = this.inMemory ? SqlDialect.SqLite : SqlDialect.PostgreSql;
        return this.inMemory ? new SQLiteConnection(this.endpointSettings.ConnectionString) : new NpgsqlConnection(this.endpointSettings.ConnectionString);
    }
}
