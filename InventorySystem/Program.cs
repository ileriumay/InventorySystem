using System;
using System.Windows.Forms;
using InventorySystem.Classes; // Veritabaný yardýmcý sýnýfýný kullanabilmek için

namespace InventorySystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Veritabaný ve tabloyu oluþtur
            SqlVariables.CreateDatabaseAndTableIfNotExists(); // Veritabaný ve tabloyu kontrol et

            // Uygulama yapýlandýrmasýný baþlat
            ApplicationConfiguration.Initialize();

            // Login formunu baþlat
            Application.Run(new FrmLogin());
        }
    }
}
