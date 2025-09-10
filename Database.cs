using System;
using System.Data.SqlClient;

public class Database
{
    private const string ConnectionString = "Data Source=localhost;Initial Catalog=SafeVault;Integrated Security=True";

    public void Initialize()
    {
        using var connection = new SqlConnection(ConnectionString);
        connection.Open();

        var command = new SqlCommand(
            "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users') " +
            "CREATE TABLE Users (Id INT PRIMARY KEY IDENTITY, Username NVARCHAR(100), Password NVARCHAR(100))",
            connection);
        command.ExecuteNonQuery();
    }

    public User GetUserByUsername(string username)
    {
        using var connection = new SqlConnection(ConnectionString);
        connection.Open();

        var command = new SqlCommand("SELECT * FROM Users WHERE Username = @username", connection);
        command.Parameters.AddWithValue("@username", username);

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            return new User
            {
                Id = (int)reader["Id"],
                Username = reader["Username"].ToString(),
                Password = reader["Password"].ToString()
            };
        }

        return null;
    }
}
