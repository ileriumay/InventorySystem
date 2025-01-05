using System;
using System.Windows.Forms;
using InventorySystem.Classes; // Veritaban� yard�mc� s�n�f�n� kullanabilmek i�in

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
            // Veritaban� ve tabloyu olu�tur
            SqlVariables.CreateDatabaseAndTableIfNotExists(); // Veritaban� ve tabloyu kontrol et

            // Uygulama yap�land�rmas�n� ba�lat
            ApplicationConfiguration.Initialize();

            // Login formunu ba�lat
            Application.Run(new FrmLogin());
        }
    }
}
