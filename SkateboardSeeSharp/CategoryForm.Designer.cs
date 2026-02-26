namespace SkateboardSeeSharp
{
    partial class CategoryForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSuggested = new System.Windows.Forms.Label();
            this.lblSuggestedList = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.panelLeft.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.lblSuggestedList);
            this.panelLeft.Controls.Add(this.lblSuggested);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Controls.Add(this.txtCategoryName);
            this.panelLeft.Controls.Add(this.lblCategoryName);
            this.panelLeft.Controls.Add(this.lblTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(25);
            this.panelLeft.Size = new System.Drawing.Size(320, 630);
            this.panelLeft.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Categories";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoryName.Location = new System.Drawing.Point(25, 70);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.lblCategoryName.Size = new System.Drawing.Size(270, 35);
            this.lblCategoryName.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCategoryName.Location = new System.Drawing.Point(25, 105);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(270, 32);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(25, 137);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(270, 55);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.Text = "ADD";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Size = new System.Drawing.Size(80, 35);
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSuggested
            // 
            this.lblSuggested.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSuggested.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSuggested.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblSuggested.Location = new System.Drawing.Point(25, 202);
            this.lblSuggested.Name = "lblSuggested";
            this.lblSuggested.Padding = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.lblSuggested.Size = new System.Drawing.Size(270, 45);
            this.lblSuggested.Text = "Suggested Categories:";
            // 
            // lblSuggestedList
            // 
            this.lblSuggestedList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSuggestedList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSuggestedList.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblSuggestedList.Location = new System.Drawing.Point(25, 247);
            this.lblSuggestedList.Name = "lblSuggestedList";
            this.lblSuggestedList.Size = new System.Drawing.Size(270, 180);
            this.lblSuggestedList.Text = "• Decks\n• Trucks\n• Wheels\n• Bearings\n• Helmets\n• Protective Gear\n• Apparel\n• Accessories";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvCategories.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategories.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCategories.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvCategories.ColumnHeadersHeight = 40;
            this.dgvCategories.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCategories.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.dgvCategories.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.Location = new System.Drawing.Point(320, 0);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowTemplate.Height = 35;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(660, 630);
            this.dgvCategories.TabIndex = 1;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.panelLeft);
            this.Name = "CategoryForm";
            this.Text = "Category Management";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSuggested;
        private System.Windows.Forms.Label lblSuggestedList;
        private System.Windows.Forms.DataGridView dgvCategories;
    }
}
