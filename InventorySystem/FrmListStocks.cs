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
            InitializeComponent();  // Initialize the form components
        }

        // Event handler for loading the form and populating the data grid with stock data
        private void ListStock_Load(object sender, EventArgs e)
        {
            try
            {
                // Check the connection to the database
                SqlVariables.CheckConnection(SqlVariables.connection);

                // Create an SQLite command to fetch all data from the "Items" table
                SQLiteCommand CommandList = new SQLiteCommand("SELECT * FROM Items", SqlVariables.connection);

                SQLiteDataAdapter da = new SQLiteDataAdapter(CommandList);  // Use data adapter to fill the data table

                DataTable dt = new DataTable();
                da.Fill(dt);  // Fill the data table with the result of the SQL command

                dataGridView1.DataSource = dt;  // Bind the data table to the data grid view
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs while loading data
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler to close the form when the cancel button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form
        }
    }
}
