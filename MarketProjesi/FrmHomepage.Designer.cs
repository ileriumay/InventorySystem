using MarketProject.Properties;

namespace MarketProject
{
    partial class FrmHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomepage));
            btnManageItems = new Button();
            btnListStocks = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnManageItems
            // 
            btnManageItems.Font = new Font("Segoe UI", 10.2F);
            btnManageItems.Image = (Image)resources.GetObject("btnManageItems.Image");
            btnManageItems.Location = new Point(40, 35);
            btnManageItems.Name = "btnManageItems";
            btnManageItems.Size = new Size(230, 152);
            btnManageItems.TabIndex = 0;
            btnManageItems.Text = "Manage Items";
            btnManageItems.TextAlign = ContentAlignment.BottomCenter;
            btnManageItems.UseVisualStyleBackColor = true;
            btnManageItems.Click += btnManageItems_Click;
            // 
            // btnListStocks
            // 
            btnListStocks.Font = new Font("Segoe UI", 10.2F);
            btnListStocks.Image = (Image)resources.GetObject("btnListStocks.Image");
            btnListStocks.Location = new Point(322, 35);
            btnListStocks.Name = "btnListStocks";
            btnListStocks.Size = new Size(230, 152);
            btnListStocks.TabIndex = 1;
            btnListStocks.Text = "List Stocks";
            btnListStocks.TextAlign = ContentAlignment.BottomCenter;
            btnListStocks.UseVisualStyleBackColor = true;
            btnListStocks.Click += btnListStocks_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(600, 35);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(230, 152);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 223);
            Controls.Add(btnClose);
            Controls.Add(btnListStocks);
            Controls.Add(btnManageItems);
            Name = "FrmHomepage";
            Text = "Homepage";
            ResumeLayout(false);
        }

        private Button btnManageItems;
        private Button btnListStocks;
        #endregion

        private Button btnClose;
    }
}