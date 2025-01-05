using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
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
            try
            {
                SqlVariables.CheckConnection(SqlVariables.connection);

                SQLiteCommand CommandList = new SQLiteCommand("SELECT * FROM Items", SqlVariables.connection);

                SQLiteDataAdapter da = new SQLiteDataAdapter(CommandList);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
