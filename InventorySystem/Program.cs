using System;
using System.Windows.Forms;
using InventorySystem.Classes;

namespace InventorySystem
{
    internal static class Program
    {
        // Main entry point for the application
        [STAThread]
        static void Main()
        {
            // Call method to create database and table if they don't exist
            SqlVariables.CreateDatabaseAndTableIfNotExists();

            // Initialize application configuration (e.g., settings, themes)
            ApplicationConfiguration.Initialize();

            // Run the login form as the starting point of the application
            Application.Run(new FrmLogin());
        }
    }
}
