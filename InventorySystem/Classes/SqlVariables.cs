using System;
using System.Data;
using System.Data.SQLite;

namespace InventorySystem.Classes
{
    public class SqlVariables
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data Source=inventory.db;Version=3;");

        public static void CheckConnection(SQLiteConnection TempConnection)
        {
            if (TempConnection.State == ConnectionState.Closed)
            {
                TempConnection.Open();  
            }
        }

        public static void CreateDatabaseAndTableIfNotExists()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Items (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Category TEXT NOT NULL,
                    ProductName TEXT NOT NULL,
                    Description TEXT,
                    Unit TEXT,
                    Amount INTEGER
                );";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();  
                    Console.WriteLine("Items table successfully created.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
