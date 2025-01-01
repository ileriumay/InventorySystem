namespace InventorySystem
{
    partial class FrmListStocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridItems = new DataGridView();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            btnCancel = new Button();
            Id = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            CurrentStock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridItems).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridItems
            // 
            gridItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridItems.BackgroundColor = SystemColors.ControlLight;
            gridItems.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridItems.Columns.AddRange(new DataGridViewColumn[] { Id, Category, ProductName, Unit, CurrentStock });
            gridItems.Dock = DockStyle.Fill;
            gridItems.Location = new Point(0, 0);
            gridItems.Name = "gridItems";
            gridItems.RowHeadersWidth = 51;
            gridItems.Size = new Size(888, 441);
            gridItems.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 383);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 58);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(782, 17);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(682, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Unit
            // 
            Unit.HeaderText = "Unit";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            // 
            // CurrentStock
            // 
            CurrentStock.HeaderText = "Current Stock";
            CurrentStock.MinimumWidth = 6;
            CurrentStock.Name = "CurrentStock";
            // 
            // FrmListStocks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 441);
            Controls.Add(groupBox1);
            Controls.Add(gridItems);
            Name = "FrmListStocks";
            Text = "List Items";
            ((System.ComponentModel.ISupportInitialize)gridItems).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridItems;
        private GroupBox groupBox1;
        private Button btnSave;
        private Button btnCancel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn CurrentStock;
    }
}