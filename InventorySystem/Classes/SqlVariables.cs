using System;
using System.Data;
using System.Data.SQLite;

namespace InventorySystem.Classes
{
    public class SqlVariables
    {
        // SQLite connection to the database 'inventory.db'
        public static SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db;Version=3;");

        // Method to check the connection state and open the connection if it's closed
        public static void CheckConnection(SQLiteConnection TempConnection)
        {
            if (TempConnection.State == ConnectionState.Closed)
            {
                TempConnection.Open();  // Open the connection if it's closed
            }
        }

        // Method to create the database and the Items table if they do not exist
        public static void CreateDatabaseAndTableIfNotExists()
        {
            try
            {
                // Check if the connection is closed and open it if necessary
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // SQL query to create the 'Items' table if it doesn't already exist
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Items (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Category TEXT NOT NULL,
                    ProductName TEXT NOT NULL,
                    Description TEXT,
                    Unit TEXT,
                    Amount INTEGER
                );";

                // Execute the SQL query to create the table
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();  // Execute the command
                    Console.WriteLine("Items table successfully created.");
                }
            }
            catch (Exception ex)
            {
                // Catch and display any errors that occur during the table creation
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Ensure that the connection is closed after the operation
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
