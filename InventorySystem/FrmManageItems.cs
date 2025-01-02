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
    public partial class FrmManageItems : Form
    {
        public FrmManageItems()
        {
            InitializeComponent();

        }

        private void ManageItems_Load(object sender, EventArgs e)
        {
            SetPlaceholder(CategoryBox, "Category");
            SetPlaceholder(ProductNameBox, "Product Name");
            SetPlaceholder(DescriptionBox, "Description");
            SetPlaceholder(UnitBox, "Unit");
            SetPlaceholder(AmountBox, "Amount");

            RefreshOrLoadPage();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, ev) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
        public void RefreshOrLoadPage()
        {
            SqlCommand CommandList = new SqlCommand("Select * from InventorySystem", SqlVariables.connection);

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

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string category = CategoryBox.Text == "Category" || string.IsNullOrWhiteSpace(CategoryBox.Text) ? "" : CategoryBox.Text;
            string productName = ProductNameBox.Text == "Product Name" || string.IsNullOrWhiteSpace(ProductNameBox.Text) ? "" : ProductNameBox.Text;
            string description = DescriptionBox.Text == "Description" ? "" : DescriptionBox.Text;
            string unit = UnitBox.Text == "Unit" || string.IsNullOrWhiteSpace(UnitBox.Text) ? "" : UnitBox.Text;
            string amount = AmountBox.Text == "Amount" || string.IsNullOrWhiteSpace(AmountBox.Text) ? "" : AmountBox.Text;

            if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(unit) || string.IsNullOrWhiteSpace(amount))
            {
                MessageBox.Show("Category, Product Name, Unit, and Amount cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            SqlCommand commandadd = new SqlCommand(
                "INSERT INTO InventorySystem (Category, ProductName, Description, Unit, Amount) VALUES (@Category, @ProductName, @Description, @Unit, @Amount)",
                SqlVariables.connection
            );

            SqlVariables.CheckConnetion(SqlVariables.connection);

            commandadd.Parameters.AddWithValue("@Category", category);
            commandadd.Parameters.AddWithValue("@ProductName", productName);
            commandadd.Parameters.AddWithValue("@Description", description);
            commandadd.Parameters.AddWithValue("@Unit", unit);
            commandadd.Parameters.AddWithValue("@Amount", amount);

            commandadd.ExecuteNonQuery();

            RefreshOrLoadPage();

            ClearTextBoxes();

            SetPlaceholder(CategoryBox, "Category");
            SetPlaceholder(ProductNameBox, "Product Name");
            SetPlaceholder(DescriptionBox, "Description");
            SetPlaceholder(UnitBox, "Unit");
            SetPlaceholder(AmountBox, "Amount");

            MessageBox.Show("Item successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearTextBoxes()
        {
            CategoryBox.Clear();
            ProductNameBox.Clear();
            DescriptionBox.Clear();
            UnitBox.Clear();
            AmountBox.Clear();
        }

        private void ResetPlaceholders()
        {
            if (string.IsNullOrWhiteSpace(CategoryBox.Text)) SetPlaceholder(CategoryBox, "Category");
            if (string.IsNullOrWhiteSpace(ProductNameBox.Text)) SetPlaceholder(ProductNameBox, "Product Name");
            if (string.IsNullOrWhiteSpace(DescriptionBox.Text)) SetPlaceholder(DescriptionBox, "Description");
            if (string.IsNullOrWhiteSpace(UnitBox.Text)) SetPlaceholder(UnitBox, "Unit");
            if (string.IsNullOrWhiteSpace(AmountBox.Text)) SetPlaceholder(AmountBox, "Amount");
        }

        private void CategoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        int SelectedID;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commanddelete = new SqlCommand("DELETE FROM InventorySystem WHERE ID = @ID", SqlVariables.connection);

            SqlVariables.CheckConnetion(SqlVariables.connection);

            commanddelete.Parameters.AddWithValue("@ID", SelectedID);

            commanddelete.ExecuteNonQuery();

            RefreshOrLoadPage();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                editCategory.Text = (dataGridView1.CurrentRow.Cells["Category"].Value).ToString();
                editProduct.Text = (dataGridView1.CurrentRow.Cells["ProductName"].Value).ToString();
                editDescription.Text = (dataGridView1.CurrentRow.Cells["Description"].Value).ToString();
                editUnit.Text = (dataGridView1.CurrentRow.Cells["Unit"].Value).ToString();
                editAmount.Text = (dataGridView1.CurrentRow.Cells["Amount"].Value).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("UPDATE InventorySystem SET Category = @Category, ProductName = @ProductName, Description = @Description, Unit = @Unit, Amount = @Amount WHERE ID = @ID", SqlVariables.connection);

            SqlVariables.CheckConnetion(SqlVariables.connection);

            commandEdit.Parameters.AddWithValue("@Category", editCategory.Text);
            commandEdit.Parameters.AddWithValue("@ProductName", editProduct.Text);
            commandEdit.Parameters.AddWithValue("@Description", editDescription.Text);
            commandEdit.Parameters.AddWithValue("@Unit", editUnit.Text);
            commandEdit.Parameters.AddWithValue("@Amount", editAmount.Text);
            commandEdit.Parameters.AddWithValue("@ID", SelectedID);

            commandEdit.ExecuteNonQuery();

            RefreshOrLoadPage();
        }
    }
}