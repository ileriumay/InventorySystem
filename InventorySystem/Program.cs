using System;
using System.Windows.Forms;
using InventorySystem.Classes;

namespace InventorySystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SqlVariables.CreateDatabaseAndTableIfNotExists();

            ApplicationConfiguration.Initialize();

            Application.Run(new FrmLogin());
        }
    }
}
