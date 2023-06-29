// <summary>
// <copyright file="BaseTest.cs" company="Sovos">
// This source code is Copyright Sovos and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Sovos (https://sovos.com/mx/).
// </copyright>
// </summary>

namespace Company.Service.Test;

/// <summary>
/// Base Test Class.
/// </summary>
public abstract class BaseTest
{
    /// <summary>
    /// Users to Create.
    /// </summary>
    /// <returns>List of Users.</returns>
    public static IEnumerable<User> GetAllUsers()
    {
        return new List<User>()
        {
            new User { Id = 1, Name = "Usuario Uno", LastName = "user1", UserType = UserType.Admin },
            new User { Id = 2, Name = "Usuario Dos", LastName = "user1", UserType = UserType.Admin },
            new User { Id = 3, Name = "Usuario Tres", LastName = "user1", UserType = UserType.Basic },
            new User { Id = 4, Name = "Usuario Cuatro", LastName = "user1", UserType = UserType.Basic },
        };
    }

    /// <summary>
    /// Users Details to Create.
    /// </summary>
    /// <returns>List of User Details.</returns>
    public static IEnumerable<UserDetail> GetAllUserDetails()
    {
        return new List<UserDetail>()
        {
            new UserDetail { Id = 1, UserId = 1, Description = "user1" },
            new UserDetail { Id = 2, UserId = 2, Description = "user2" },
            new UserDetail { Id = 3, UserId = 3, Description = "user3" },
            new UserDetail { Id = 4, UserId = 4, Description = "user4" },
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
                    CREATE TABLE tbl_user (
                        id long primary key,
                        name varchar(100),
                        lastname varchar(100),
                        email varchar(100),
                        userType varchar(100)
                    );

                    CREATE TABLE tbl_user_detail (
                        id long primary key,
                        userid long,
                        description varchar(100)
                    );
                ";

            createCommand.ExecuteNonQuery();

            foreach (var item in GetAllUsers())
            {
                connection.Insert(item);
            }

            foreach (var item in GetAllUserDetails())
            {
                connection.Insert(item);
            }

            connection.Close();
        }
    }
}
