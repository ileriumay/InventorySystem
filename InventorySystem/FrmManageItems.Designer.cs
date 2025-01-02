namespace InventorySystem
{
    partial class FrmManageItems
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            CategoryBox = new TextBox();
            ProductNameBox = new TextBox();
            DescriptionBox = new TextBox();
            UnitBox = new TextBox();
            AmountBox = new TextBox();
            btnEdit = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            editAmount = new TextBox();
            editUnit = new TextBox();
            editDescription = new TextBox();
            editProduct = new TextBox();
            editCategory = new TextBox();
            groupBox2 = new GroupBox();
            btnE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(794, 307);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // CategoryBox
            // 
            CategoryBox.Location = new Point(12, 20);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(125, 27);
            CategoryBox.TabIndex = 1;
            // 
            // ProductNameBox
            // 
            ProductNameBox.Location = new Point(143, 20);
            ProductNameBox.Name = "ProductNameBox";
            ProductNameBox.Size = new Size(125, 27);
            ProductNameBox.TabIndex = 2;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(274, 20);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(125, 27);
            DescriptionBox.TabIndex = 3;
            // 
            // UnitBox
            // 
            UnitBox.Location = new Point(405, 20);
            UnitBox.Name = "UnitBox";
            UnitBox.Size = new Size(125, 27);
            UnitBox.TabIndex = 4;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(536, 20);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(125, 27);
            AmountBox.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(667, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 31);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(697, 422);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(609, 422);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(editAmount);
            groupBox1.Controls.Add(editUnit);
            groupBox1.Controls.Add(editDescription);
            groupBox1.Controls.Add(editProduct);
            groupBox1.Controls.Add(editCategory);
            groupBox1.Location = new Point(10, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 53);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Product";
            // 
            // editAmount
            // 
            editAmount.Location = new Point(536, 20);
            editAmount.Name = "editAmount";
            editAmount.Size = new Size(125, 27);
            editAmount.TabIndex = 5;
            // 
            // editUnit
            // 
            editUnit.Location = new Point(405, 20);
            editUnit.Name = "editUnit";
            editUnit.Size = new Size(125, 27);
            editUnit.TabIndex = 4;
            // 
            // editDescription
            // 
            editDescription.Location = new Point(274, 20);
            editDescription.Name = "editDescription";
            editDescription.Size = new Size(125, 27);
            editDescription.TabIndex = 3;
            // 
            // editProduct
            // 
            editProduct.Location = new Point(143, 20);
            editProduct.Name = "editProduct";
            editProduct.Size = new Size(125, 27);
            editProduct.TabIndex = 2;
            // 
            // editCategory
            // 
            editCategory.Location = new Point(12, 20);
            editCategory.Name = "editCategory";
            editCategory.Size = new Size(125, 27);
            editCategory.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnE);
            groupBox2.Controls.Add(AmountBox);
            groupBox2.Controls.Add(UnitBox);
            groupBox2.Controls.Add(DescriptionBox);
            groupBox2.Controls.Add(ProductNameBox);
            groupBox2.Controls.Add(CategoryBox);
            groupBox2.Location = new Point(10, 367);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(769, 53);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Product";
            // 
            // btnE
            // 
            btnE.Location = new Point(667, 18);
            btnE.Name = "btnE";
            btnE.Size = new Size(82, 31);
            btnE.TabIndex = 6;
            btnE.Text = "Add";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += btnSave_Click;
            // 
            // FrmManageItems
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(dataGridView1);
            Name = "FrmManageItems";
            Text = "Manage Items";
            Load += ManageItems_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox UnitBox;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnE;
        private TextBox editAmount;
        private TextBox editUnit;
        private TextBox editDescription;
        private TextBox editProduct;
        private TextBox editCategory;
    }
}
