using System;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
         
            DatabaseHelper.InitializeDatabase();

           
            Console.WriteLine("Application has started.");

         
        }
    }
}
