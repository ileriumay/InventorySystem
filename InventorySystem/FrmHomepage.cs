using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class FrmHomepage : Form
    {
        // Constructor to initialize the form components
        public FrmHomepage()
        {
            InitializeComponent();
        }

        // Event handler for the 'Manage Items' button click
        private void btnManageItems_Click(object sender, EventArgs e)
        {
            var manageItems = new FrmManageItems();  // Create an instance of FrmManageItems form
            manageItems.Show();  // Show the 'Manage Items' form
        }

        // Event handler for the 'List Stocks' button click
        private void btnListStocks_Click(object sender, EventArgs e)
        {
            var listStocks = new FrmListStocks();  // Create an instance of FrmListStocks form
            listStocks.Show();  // Show the 'List Stocks' form
        }

        // Event handler for the 'Close' button click
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog asking if the user is sure about closing the application
            DialogResult dialogResult = MessageBox.Show("Application will be closed. Are you sure?", "Sure?", MessageBoxButtons.YesNo);

            // If the user clicks 'Yes', the application will exit
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();  // Close the application
            }
        }
    }
}
