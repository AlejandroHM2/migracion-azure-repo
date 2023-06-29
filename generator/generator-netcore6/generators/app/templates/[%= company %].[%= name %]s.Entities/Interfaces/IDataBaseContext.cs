// <summary>
// <copyright file="IDataBaseContext.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Entities.Interfaces;

/// <summary>
/// DataBase Context Interface.
/// </summary>
public interface IDataBaseContext
{
    /// <summary>
    /// DB Open Connection.
    /// </summary>
    /// <returns>Object to Connection.</returns>
    IDbConnection OpenConnection();
}
