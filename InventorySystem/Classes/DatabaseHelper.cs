using System;
using System.Data.SQLite;

namespace InventorySystem
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Data Source=inventory.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Items (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Category TEXT NOT NULL,
                        ProductName TEXT NOT NULL,
                        Description TEXT,
                        Unit TEXT NOT NULL,
                        Amount INTEGER NOT NULL
                    );";

                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Items table successfully created or already exists.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Database error: {ex.Message}");
                }
            }
        }
    }
}
