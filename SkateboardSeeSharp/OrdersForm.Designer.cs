namespace SkateboardSeeSharp
{
    partial class OrdersForm
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
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvOrderLines = new System.Windows.Forms.DataGridView();
            this.panelOrderEntry = new System.Windows.Forms.Panel();
            this.lblOrderEntryTitle = new System.Windows.Forms.Label();
            this.lblCatLabel = new System.Windows.Forms.Label();
            this.cmbOrderCategory = new System.Windows.Forms.ComboBox();
            this.lblProdIdLabel = new System.Windows.Forms.Label();
            this.cmbProductId = new System.Windows.Forms.ComboBox();
            this.lblProdNameLabel = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQtyLabel = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.flowOrderButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.lblCustLabel = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscountLabel = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblFinalTotalLabel = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblTenderedLabel = new System.Windows.Forms.Label();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.lblChangeLabel = new System.Windows.Forms.Label();
            this.lblChangeDue = new System.Windows.Forms.Label();
            this.btnPayOrder = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelOrderEntry.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.flowOrderButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Size = new System.Drawing.Size(980, 630);
            this.splitMain.SplitterDistance = 650;
            this.splitMain.TabIndex = 0;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitLeft.Size = new System.Drawing.Size(650, 630);
            this.splitLeft.SplitterDistance = 310;
            // splitLeft.Panel1 = products grid
            // splitLeft.Panel2 = order lines grid
            this.splitMain.Panel1.Controls.Add(this.splitLeft);

            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.cmbFilterCategory);
            this.panelFilter.Controls.Add(this.lblProducts);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Size = new System.Drawing.Size(650, 70);
            this.panelFilter.Padding = new System.Windows.Forms.Padding(10);
            this.splitLeft.Panel1.Controls.Add(this.dgvProducts);
            this.splitLeft.Panel1.Controls.Add(this.panelFilter);
            // 
            // lblProducts
            // 
            this.lblProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProducts.Size = new System.Drawing.Size(170, 50);
            this.lblProducts.Text = "Available Products";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterCategory.Location = new System.Drawing.Point(180, 15);
            this.cmbFilterCategory.Size = new System.Drawing.Size(200, 28);
            this.cmbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(420, 15);
            this.txtSearch.Size = new System.Drawing.Size(200, 30);
            // Placeholder handled via watermark approach in .NET Framework
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            // panelOrderEntry
            // 
            this.panelOrderEntry.BackColor = System.Drawing.Color.White;
            this.panelOrderEntry.Controls.Add(this.flowOrderButtons);
            this.panelOrderEntry.Controls.Add(this.nudQuantity);
            this.panelOrderEntry.Controls.Add(this.lblQtyLabel);
            this.panelOrderEntry.Controls.Add(this.txtPrice);
            this.panelOrderEntry.Controls.Add(this.lblPriceLabel);
            this.panelOrderEntry.Controls.Add(this.txtProductName);
            this.panelOrderEntry.Controls.Add(this.lblProdNameLabel);
            this.panelOrderEntry.Controls.Add(this.cmbProductId);
            this.panelOrderEntry.Controls.Add(this.lblProdIdLabel);
            this.panelOrderEntry.Controls.Add(this.cmbOrderCategory);
            this.panelOrderEntry.Controls.Add(this.lblCatLabel);
            this.panelOrderEntry.Controls.Add(this.lblOrderEntryTitle);
            this.panelOrderEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderEntry.Padding = new System.Windows.Forms.Padding(10);
            this.panelOrderEntry.Size = new System.Drawing.Size(650, 100);
            this.splitLeft.Panel2.Controls.Add(this.dgvOrderLines);
            this.splitLeft.Panel2.Controls.Add(this.panelOrderEntry);
            // 
            // lblOrderEntryTitle
            // 
            this.lblOrderEntryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderEntryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrderEntryTitle.Size = new System.Drawing.Size(630, 25);
            this.lblOrderEntryTitle.Text = "Order Entry";
            // 
            // lblCatLabel
            // 
            this.lblCatLabel.AutoSize = true;
            this.lblCatLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCatLabel.Location = new System.Drawing.Point(10, 35);
            this.lblCatLabel.Text = "Category:";
            // 
            // cmbOrderCategory
            // 
            this.cmbOrderCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderCategory.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbOrderCategory.Location = new System.Drawing.Point(10, 53);
            this.cmbOrderCategory.Size = new System.Drawing.Size(120, 26);
            this.cmbOrderCategory.SelectedIndexChanged += new System.EventHandler(this.cmbOrderCategory_SelectedIndexChanged);
            // 
            // lblProdIdLabel
            // 
            this.lblProdIdLabel.AutoSize = true;
            this.lblProdIdLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProdIdLabel.Location = new System.Drawing.Point(135, 35);
            this.lblProdIdLabel.Text = "Product:";
            // 
            // cmbProductId
            // 
            this.cmbProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductId.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbProductId.Location = new System.Drawing.Point(135, 53);
            this.cmbProductId.Size = new System.Drawing.Size(110, 26);
            this.cmbProductId.SelectedIndexChanged += new System.EventHandler(this.cmbProductId_SelectedIndexChanged);
            // 
            // lblProdNameLabel
            // 
            this.lblProdNameLabel.AutoSize = true;
            this.lblProdNameLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProdNameLabel.Location = new System.Drawing.Point(250, 35);
            this.lblProdNameLabel.Text = "Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtProductName.Location = new System.Drawing.Point(250, 53);
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(120, 25);
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPriceLabel.Location = new System.Drawing.Point(375, 35);
            this.lblPriceLabel.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPrice.Location = new System.Drawing.Point(375, 53);
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(70, 25);
            // 
            // lblQtyLabel
            // 
            this.lblQtyLabel.AutoSize = true;
            this.lblQtyLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblQtyLabel.Location = new System.Drawing.Point(450, 35);
            this.lblQtyLabel.Text = "Qty:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nudQuantity.Location = new System.Drawing.Point(450, 53);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Value = 1;
            this.nudQuantity.Size = new System.Drawing.Size(55, 25);
            // 
            // flowOrderButtons
            // 
            this.flowOrderButtons.Controls.Add(this.btnAddToOrder);
            this.flowOrderButtons.Controls.Add(this.btnRemove);
            this.flowOrderButtons.Controls.Add(this.btnClearOrder);
            this.flowOrderButtons.Location = new System.Drawing.Point(515, 45);
            this.flowOrderButtons.Size = new System.Drawing.Size(130, 40);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAddToOrder.FlatAppearance.BorderSize = 0;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Size = new System.Drawing.Size(38, 28);
            this.btnAddToOrder.Text = "+";
            this.btnAddToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Size = new System.Drawing.Size(38, 28);
            this.btnRemove.Text = "-";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClearOrder.FlatAppearance.BorderSize = 0;
            this.btnClearOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOrder.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnClearOrder.ForeColor = System.Drawing.Color.White;
            this.btnClearOrder.Size = new System.Drawing.Size(45, 28);
            this.btnClearOrder.Text = "CLR";
            this.btnClearOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.AllowUserToAddRows = false;
            this.dgvOrderLines.AllowUserToDeleteRows = false;
            this.dgvOrderLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderLines.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.dgvOrderLines.ColumnHeadersHeight = 35;
            this.dgvOrderLines.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvOrderLines.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.dgvOrderLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderLines.EnableHeadersVisualStyles = false;
            this.dgvOrderLines.ReadOnly = true;
            this.dgvOrderLines.RowHeadersVisible = false;
            this.dgvOrderLines.RowTemplate.Height = 30;
            this.dgvOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // panelPayment (Right panel)
            // 
            this.panelPayment.BackColor = System.Drawing.Color.White;
            this.panelPayment.Controls.Add(this.btnPayOrder);
            this.panelPayment.Controls.Add(this.lblChangeDue);
            this.panelPayment.Controls.Add(this.lblChangeLabel);
            this.panelPayment.Controls.Add(this.txtAmountTendered);
            this.panelPayment.Controls.Add(this.lblTenderedLabel);
            this.panelPayment.Controls.Add(this.lblFinalTotal);
            this.panelPayment.Controls.Add(this.lblFinalTotalLabel);
            this.panelPayment.Controls.Add(this.txtDiscount);
            this.panelPayment.Controls.Add(this.lblDiscountLabel);
            this.panelPayment.Controls.Add(this.lblTotalPrice);
            this.panelPayment.Controls.Add(this.lblTotalLabel);
            this.panelPayment.Controls.Add(this.cmbCustomer);
            this.panelPayment.Controls.Add(this.lblCustLabel);
            this.panelPayment.Controls.Add(this.lblPaymentTitle);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayment.Padding = new System.Windows.Forms.Padding(15);
            this.splitMain.Panel2.Controls.Add(this.panelPayment);
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPaymentTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblPaymentTitle.Size = new System.Drawing.Size(296, 40);
            this.lblPaymentTitle.Text = "Payment";
            // 
            // lblCustLabel
            // 
            this.lblCustLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.lblCustLabel.Size = new System.Drawing.Size(296, 30);
            this.lblCustLabel.Text = "Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCustomer.Size = new System.Drawing.Size(296, 31);
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 3);
            this.lblTotalLabel.Size = new System.Drawing.Size(296, 35);
            this.lblTotalLabel.Text = "Subtotal";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblTotalPrice.Size = new System.Drawing.Size(296, 35);
            this.lblTotalPrice.Text = "0.00";
            // 
            // lblDiscountLabel
            // 
            this.lblDiscountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiscountLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.lblDiscountLabel.Size = new System.Drawing.Size(296, 30);
            this.lblDiscountLabel.Text = "Discount Amount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiscount.Size = new System.Drawing.Size(296, 32);
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblFinalTotalLabel
            // 
            this.lblFinalTotalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFinalTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotalLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.lblFinalTotalLabel.Size = new System.Drawing.Size(296, 30);
            this.lblFinalTotalLabel.Text = "Total Due";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFinalTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotal.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblFinalTotal.Size = new System.Drawing.Size(296, 45);
            this.lblFinalTotal.Text = "0.00";
            // 
            // lblTenderedLabel
            // 
            this.lblTenderedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenderedLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenderedLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.lblTenderedLabel.Size = new System.Drawing.Size(296, 30);
            this.lblTenderedLabel.Text = "Amount Tendered";
            // 
            // txtAmountTendered
            // 
            this.txtAmountTendered.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAmountTendered.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmountTendered.Size = new System.Drawing.Size(296, 32);
            this.txtAmountTendered.Text = "0";
            this.txtAmountTendered.TextChanged += new System.EventHandler(this.txtAmountTendered_TextChanged);
            // 
            // lblChangeLabel
            // 
            this.lblChangeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChangeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChangeLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.lblChangeLabel.Size = new System.Drawing.Size(296, 30);
            this.lblChangeLabel.Text = "Change Due";
            // 
            // lblChangeDue
            // 
            this.lblChangeDue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChangeDue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblChangeDue.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.lblChangeDue.Size = new System.Drawing.Size(296, 35);
            this.lblChangeDue.Text = "0.00";
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnPayOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayOrder.FlatAppearance.BorderSize = 0;
            this.btnPayOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayOrder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPayOrder.ForeColor = System.Drawing.Color.White;
            this.btnPayOrder.Size = new System.Drawing.Size(296, 55);
            this.btnPayOrder.Text = "💰  PAY ORDER";
            this.btnPayOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.splitMain);
            this.Name = "OrdersForm";
            this.Text = "Point of Sale";
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelOrderEntry.ResumeLayout(false);
            this.panelOrderEntry.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.flowOrderButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvOrderLines;
        private System.Windows.Forms.Panel panelOrderEntry;
        private System.Windows.Forms.Label lblOrderEntryTitle;
        private System.Windows.Forms.Label lblCatLabel;
        private System.Windows.Forms.ComboBox cmbOrderCategory;
        private System.Windows.Forms.Label lblProdIdLabel;
        private System.Windows.Forms.ComboBox cmbProductId;
        private System.Windows.Forms.Label lblProdNameLabel;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQtyLabel;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowOrderButtons;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.Label lblCustLabel;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDiscountLabel;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblFinalTotalLabel;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblTenderedLabel;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.Label lblChangeLabel;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.Button btnPayOrder;
    }
}
