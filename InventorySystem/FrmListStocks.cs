using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using InventorySystem.Classes;


namespace InventorySystem
{
    public partial class FrmListStocks : Form
    {
        public FrmListStocks()
        {
            InitializeComponent();
        }

        private void ListStock_Load(object sender, EventArgs e)
        {
            SqlCommand CommandList = new SqlCommand("Select * from InventorySystem",SqlVariables.connection);

            SqlVariables.CheckConnetion(SqlVariables.connection);

            SqlDataAdapter da = new SqlDataAdapter(CommandList);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListStocks_Load(object sender, EventArgs e)
        {

        }
    }
}
