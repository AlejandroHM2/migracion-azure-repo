// <summary>
// <copyright file="BaseTest.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace [%= company %].[%= name %]s.Test;

/// <summary>
/// Base Test Class.
/// </summary>
public abstract class BaseTest
{
    /// <summary>
    /// [%= name %]s to Create.
    /// </summary>
    /// <returns>List of [%= name %]s.</returns>
    public static IEnumerable<[%= name %]> GetAll[%= name %]s()
    {
        return new List<[%= name %]>()
        {
            new [%= name %] { Id = 1, Name = "Usuario Uno", LastName = "[%= name_lower %]1", [%= name %]Type = [%= name %]Type.Admin },
            new [%= name %] { Id = 2, Name = "Usuario Dos", LastName = "[%= name_lower %]1", [%= name %]Type = [%= name %]Type.Admin },
            new [%= name %] { Id = 3, Name = "Usuario Tres", LastName = "[%= name_lower %]1", [%= name %]Type = [%= name %]Type.Basic },
            new [%= name %] { Id = 4, Name = "Usuario Cuatro", LastName = "[%= name_lower %]1", [%= name %]Type = [%= name %]Type.Basic },
        };
    }

    /// <summary>
    /// [%= name %]s Details to Create.
    /// </summary>
    /// <returns>List of [%= name %] Details.</returns>
    public static IEnumerable<[%= name %]Detail> GetAll[%= name %]Details()
    {
        return new List<[%= name %]Detail>()
        {
            new [%= name %]Detail { Id = 1, [%= name %]Id = 1, Description = "[%= name_lower %]1" },
            new [%= name %]Detail { Id = 2, [%= name %]Id = 2, Description = "[%= name_lower %]2" },
            new [%= name %]Detail { Id = 3, [%= name %]Id = 3, Description = "[%= name_lower %]3" },
            new [%= name %]Detail { Id = 4, [%= name %]Id = 4, Description = "[%= name_lower %]4" },
        };
    }

    /// <summary>
    /// Create Test Tables.
    /// </summary>
    /// <param name="dataBaseContext">Data Base Context.</param>
    public static void CreateTables(IDataBaseContext dataBaseContext)
    {
        SQLiteConnection.CreateFile("MyDatabase.sqlite");
        using (var connection = dataBaseContext.OpenConnection())
        {
            connection.Open();
            var createCommand = connection.CreateCommand();
            createCommand.CommandText =
            @"
                    CREATE TABLE tbl_[%= name_lower %] (
                        id long primary key,
                        name varchar(100),
                        lastname varchar(100),
                        email varchar(100),
                        [%= name_lower %]Type varchar(100)
                    );

                    CREATE TABLE tbl_[%= name_lower %]_detail (
                        id long primary key,
                        [%= name_lower %]id long,
                        description varchar(100)
                    );
                ";

            createCommand.ExecuteNonQuery();

            foreach (var item in GetAll[%= name %]s())
            {
                connection.Insert(item);
            }

            foreach (var item in GetAll[%= name %]Details())
            {
                connection.Insert(item);
            }

            connection.Close();
        }
    }
}
