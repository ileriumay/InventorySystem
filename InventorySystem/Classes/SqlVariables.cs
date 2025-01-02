using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 

namespace InventorySystem.Classes
{
    public class SqlVariables
    {
        public static SqlConnection connection = new SqlConnection("Data Source=EFE;Initial Catalog=InventorySystem;Integrated Security=True;Trust Server Certificate=True");

        public static void CheckConnetion(SqlConnection TempConnection)
        {
            if (TempConnection.State == ConnectionState.Closed)
            {
                TempConnection.Open();
            }
        }


    }
}