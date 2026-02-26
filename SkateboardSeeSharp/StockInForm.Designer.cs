namespace SkateboardSeeSharp
{
    partial class StockInForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelProductTop = new System.Windows.Forms.Panel();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelProductFields = new System.Windows.Forms.Panel();
            this.lblFieldsTitle = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.flowProductButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelImport = new System.Windows.Forms.Panel();
            this.lblImportTitle = new System.Windows.Forms.Label();
            this.lblImportPrice = new System.Windows.Forms.Label();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.lblImportQty = new System.Windows.Forms.Label();
            this.nudImportQty = new System.Windows.Forms.NumericUpDown();
            this.lblImportNotes = new System.Windows.Forms.Label();
            this.txtImportNotes = new System.Windows.Forms.TextBox();
            this.flowImportButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddToImport = new System.Windows.Forms.Button();
            this.btnSaveImport = new System.Windows.Forms.Button();
            this.dgvImportLines = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImportQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportLines)).BeginInit();
            this.panelProductTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelProductFields.SuspendLayout();
            this.panelImport.SuspendLayout();
            this.flowProductButtons.SuspendLayout();
            this.flowImportButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Size = new System.Drawing.Size(980, 630);
            this.splitMain.SplitterDistance = 580;
            // Left = product grid, Right = fields + import
            this.splitMain.Panel1.Controls.Add(this.dgvProducts);
            this.splitMain.Panel1.Controls.Add(this.panelProductTop);
            this.splitMain.Panel2.Controls.Add(this.panelRight);
            // 
            // panelProductTop
            // 
            this.panelProductTop.BackColor = System.Drawing.Color.White;
            this.panelProductTop.Controls.Add(this.lblProductTitle);
            this.panelProductTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductTop.Size = new System.Drawing.Size(580, 45);
            this.panelProductTop.Padding = new System.Windows.Forms.Padding(15, 10, 10, 5);
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblProductTitle.Text = "Inventory / Stock In";
            this.lblProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvProducts.ColumnHeadersHeight = 35;
            this.dgvProducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 30;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // panelRight
            // 
            this.panelRight.AutoScroll = true;
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.dgvImportLines);
            this.panelRight.Controls.Add(this.panelImport);
            this.panelRight.Controls.Add(this.panelProductFields);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            // 
            // panelProductFields
            // 
            this.panelProductFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductFields.Size = new System.Drawing.Size(376, 340);
            this.panelProductFields.Controls.Add(this.flowProductButtons);
            this.panelProductFields.Controls.Add(this.txtDescription);
            this.panelProductFields.Controls.Add(this.lblDesc);
            this.panelProductFields.Controls.Add(this.cmbStatus);
            this.panelProductFields.Controls.Add(this.lblStatus);
            this.panelProductFields.Controls.Add(this.nudStock);
            this.panelProductFields.Controls.Add(this.lblStock);
            this.panelProductFields.Controls.Add(this.txtPrice);
            this.panelProductFields.Controls.Add(this.lblPrice);
            this.panelProductFields.Controls.Add(this.cmbCategory);
            this.panelProductFields.Controls.Add(this.lblCategory);
            this.panelProductFields.Controls.Add(this.txtProductName);
            this.panelProductFields.Controls.Add(this.lblProductName);
            this.panelProductFields.Controls.Add(this.txtProductId);
            this.panelProductFields.Controls.Add(this.lblProductId);
            this.panelProductFields.Controls.Add(this.lblFieldsTitle);
            // 
            // lblFieldsTitle
            // 
            this.lblFieldsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFieldsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFieldsTitle.Size = new System.Drawing.Size(376, 28);
            this.lblFieldsTitle.Text = "Product Details";
            // 
            // lblProductId
            // 
            this.lblProductId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProductId.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.lblProductId.Size = new System.Drawing.Size(376, 20);
            this.lblProductId.Text = "Product ID (auto-generated)";
            // 
            // txtProductId
            // 
            this.txtProductId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProductId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(376, 27);
            // 
            // lblProductName
            // 
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProductName.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.lblProductName.Size = new System.Drawing.Size(376, 20);
            this.lblProductName.Text = "Product Name *";
            // 
            // txtProductName
            // 
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.Size = new System.Drawing.Size(376, 27);
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCategory.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.lblCategory.Size = new System.Drawing.Size(376, 20);
            this.lblCategory.Text = "Category *";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategory.Size = new System.Drawing.Size(376, 28);
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.lblPrice.Size = new System.Drawing.Size(376, 20);
            this.lblPrice.Text = "Selling Price *";
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Size = new System.Drawing.Size(376, 27);
            // 
            // lblStock
            // 
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStock.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.lblStock.Size = new System.Drawing.Size(376, 20);
            this.lblStock.Text = "Stock Quantity";
            // 
            // nudStock
            // 
            this.nudStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudStock.Maximum = 99999;
            this.nudStock.Size = new System.Drawing.Size(376, 27);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.lblStatus.Size = new System.Drawing.Size(376, 20);
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.Items.AddRange(new object[] { "In Stock", "Out of Stock", "Discontinued" });
            this.cmbStatus.Size = new System.Drawing.Size(376, 28);
            this.cmbStatus.SelectedIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDesc.Padding = new System.Windows.Forms.Padding(0, 4, 0, 1);
            this.lblDesc.Size = new System.Drawing.Size(376, 20);
            this.lblDesc.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Size = new System.Drawing.Size(376, 27);
            // 
            // flowProductButtons
            // 
            this.flowProductButtons.Controls.Add(this.btnAddProduct);
            this.flowProductButtons.Controls.Add(this.btnDeleteProduct);
            this.flowProductButtons.Controls.Add(this.btnClear);
            this.flowProductButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowProductButtons.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowProductButtons.Size = new System.Drawing.Size(376, 42);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Size = new System.Drawing.Size(110, 30);
            this.btnAddProduct.Text = "ADD PRODUCT";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(70, 30);
            this.btnClear.Text = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelImport
            // 
            this.panelImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImport.Size = new System.Drawing.Size(376, 140);
            this.panelImport.Controls.Add(this.flowImportButtons);
            this.panelImport.Controls.Add(this.txtImportNotes);
            this.panelImport.Controls.Add(this.lblImportNotes);
            this.panelImport.Controls.Add(this.nudImportQty);
            this.panelImport.Controls.Add(this.lblImportQty);
            this.panelImport.Controls.Add(this.txtImportPrice);
            this.panelImport.Controls.Add(this.lblImportPrice);
            this.panelImport.Controls.Add(this.lblImportTitle);
            // 
            // lblImportTitle
            // 
            this.lblImportTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImportTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblImportTitle.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblImportTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblImportTitle.Size = new System.Drawing.Size(376, 30);
            this.lblImportTitle.Text = "Import / Stock In";
            // 
            // lblImportPrice
            // 
            this.lblImportPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImportPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblImportPrice.Padding = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.lblImportPrice.Size = new System.Drawing.Size(376, 18);
            this.lblImportPrice.Text = "Import Price";
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtImportPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImportPrice.Size = new System.Drawing.Size(376, 27);
            // 
            // lblImportQty
            // 
            this.lblImportQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImportQty.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblImportQty.Padding = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.lblImportQty.Size = new System.Drawing.Size(376, 18);
            this.lblImportQty.Text = "Import Quantity";
            // 
            // nudImportQty
            // 
            this.nudImportQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudImportQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudImportQty.Minimum = 1;
            this.nudImportQty.Value = 1;
            this.nudImportQty.Maximum = 99999;
            this.nudImportQty.Size = new System.Drawing.Size(376, 27);
            // 
            // lblImportNotes
            // 
            this.lblImportNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImportNotes.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblImportNotes.Padding = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.lblImportNotes.Size = new System.Drawing.Size(376, 18);
            this.lblImportNotes.Text = "Notes";
            // 
            // txtImportNotes
            // 
            this.txtImportNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtImportNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImportNotes.Size = new System.Drawing.Size(376, 27);
            // 
            // flowImportButtons
            // 
            this.flowImportButtons.Controls.Add(this.btnAddToImport);
            this.flowImportButtons.Controls.Add(this.btnSaveImport);
            this.flowImportButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowImportButtons.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowImportButtons.Size = new System.Drawing.Size(376, 42);
            // 
            // btnAddToImport
            // 
            this.btnAddToImport.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnAddToImport.FlatAppearance.BorderSize = 0;
            this.btnAddToImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToImport.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddToImport.ForeColor = System.Drawing.Color.White;
            this.btnAddToImport.Size = new System.Drawing.Size(120, 30);
            this.btnAddToImport.Text = "ADD TO IMPORT";
            this.btnAddToImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToImport.Click += new System.EventHandler(this.btnAddToImport_Click);
            // 
            // btnSaveImport
            // 
            this.btnSaveImport.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSaveImport.FlatAppearance.BorderSize = 0;
            this.btnSaveImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImport.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnSaveImport.ForeColor = System.Drawing.Color.White;
            this.btnSaveImport.Size = new System.Drawing.Size(120, 30);
            this.btnSaveImport.Text = "SAVE IMPORT";
            this.btnSaveImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveImport.Click += new System.EventHandler(this.btnSaveImport_Click);
            // 
            // dgvImportLines
            // 
            this.dgvImportLines.AllowUserToAddRows = false;
            this.dgvImportLines.AllowUserToDeleteRows = false;
            this.dgvImportLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportLines.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImportLines.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.dgvImportLines.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvImportLines.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dgvImportLines.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.dgvImportLines.ColumnHeadersHeight = 30;
            this.dgvImportLines.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvImportLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportLines.EnableHeadersVisualStyles = false;
            this.dgvImportLines.ReadOnly = true;
            this.dgvImportLines.RowHeadersVisible = false;
            this.dgvImportLines.RowTemplate.Height = 25;
            this.dgvImportLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.splitMain);
            this.Name = "StockInForm";
            this.Text = "Stock In / Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImportQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportLines)).EndInit();
            this.panelProductTop.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelProductFields.ResumeLayout(false);
            this.panelProductFields.PerformLayout();
            this.panelImport.ResumeLayout(false);
            this.panelImport.PerformLayout();
            this.flowProductButtons.ResumeLayout(false);
            this.flowImportButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelProductTop;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelProductFields;
        private System.Windows.Forms.Label lblFieldsTitle;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flowProductButtons;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelImport;
        private System.Windows.Forms.Label lblImportTitle;
        private System.Windows.Forms.Label lblImportPrice;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.Label lblImportQty;
        private System.Windows.Forms.NumericUpDown nudImportQty;
        private System.Windows.Forms.Label lblImportNotes;
        private System.Windows.Forms.TextBox txtImportNotes;
        private System.Windows.Forms.FlowLayoutPanel flowImportButtons;
        private System.Windows.Forms.Button btnAddToImport;
        private System.Windows.Forms.Button btnSaveImport;
        private System.Windows.Forms.DataGridView dgvImportLines;
    }
}
