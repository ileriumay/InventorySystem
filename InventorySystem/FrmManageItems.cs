using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using InventorySystem.Classes;

namespace InventorySystem
{
    public partial class FrmManageItems : Form
    {
        private int SelectedID;  

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
            SQLiteCommand CommandList = new SQLiteCommand("SELECT * FROM Items", SqlVariables.connection);
            SqlVariables.CheckConnection(SqlVariables.connection);

            SQLiteDataAdapter da = new SQLiteDataAdapter(CommandList);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

            SQLiteCommand commandadd = new SQLiteCommand(
                "INSERT INTO Items (Category, ProductName, Description, Unit, Amount) VALUES (@Category, @ProductName, @Description, @Unit, @Amount)",
                SqlVariables.connection
            );

            SqlVariables.CheckConnection(SqlVariables.connection);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedID > 0)
            {
                SQLiteCommand commanddelete = new SQLiteCommand("DELETE FROM Items WHERE ID = @ID", SqlVariables.connection);

                SqlVariables.CheckConnection(SqlVariables.connection);

                commanddelete.Parameters.AddWithValue("@ID", SelectedID);

                commanddelete.ExecuteNonQuery();  

                RefreshOrLoadPage(); 
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                SelectedID = 0;  
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedID > 0)
            {
                SQLiteCommand commandEdit = new SQLiteCommand("UPDATE Items SET Category = @Category, ProductName = @ProductName, Description = @Description, Unit = @Unit, Amount = @Amount WHERE ID = @ID", SqlVariables.connection);

                SqlVariables.CheckConnection(SqlVariables.connection);

                commandEdit.Parameters.AddWithValue("@Category", editCategory.Text);
                commandEdit.Parameters.AddWithValue("@ProductName", editProduct.Text);
                commandEdit.Parameters.AddWithValue("@Description", editDescription.Text);
                commandEdit.Parameters.AddWithValue("@Unit", editUnit.Text);
                commandEdit.Parameters.AddWithValue("@Amount", editAmount.Text);
                commandEdit.Parameters.AddWithValue("@ID", SelectedID);

                commandEdit.ExecuteNonQuery();  

                RefreshOrLoadPage();
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
