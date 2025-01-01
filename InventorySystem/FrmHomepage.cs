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
        public FrmHomepage()
        {
            InitializeComponent();
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            var manageItems = new FrmManageItems();
            manageItems.Show();

        }

        private void btnListStocks_Click(object sender, EventArgs e)
        {
            var listStocks = new FrmListStocks();
            listStocks.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application will be close. Are you sure?", "Sure? ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
