namespace SkateboardSeeSharp
{
    partial class EmployeeForm
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
            this.panelFields = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.cmbAuthority = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panelFields.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFields
            // 
            this.panelFields.AutoScroll = true;
            this.panelFields.BackColor = System.Drawing.Color.White;
            this.panelFields.Controls.Add(this.lblTitle);
            this.panelFields.Controls.Add(this.lblEmployeeName);
            this.panelFields.Controls.Add(this.txtEmployeeName);
            this.panelFields.Controls.Add(this.lblUsername);
            this.panelFields.Controls.Add(this.txtUsername);
            this.panelFields.Controls.Add(this.lblPassword);
            this.panelFields.Controls.Add(this.txtPassword);
            this.panelFields.Controls.Add(this.lblPosition);
            this.panelFields.Controls.Add(this.cmbPosition);
            this.panelFields.Controls.Add(this.lblAuthority);
            this.panelFields.Controls.Add(this.cmbAuthority);
            this.panelFields.Controls.Add(this.lblPhone);
            this.panelFields.Controls.Add(this.txtPhone);
            this.panelFields.Controls.Add(this.lblEmail);
            this.panelFields.Controls.Add(this.txtEmail);
            this.panelFields.Controls.Add(this.panelButtons);
            this.panelFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFields.Location = new System.Drawing.Point(0, 0);
            this.panelFields.Name = "panelFields";
            this.panelFields.Padding = new System.Windows.Forms.Padding(20);
            this.panelFields.Size = new System.Drawing.Size(350, 630);
            this.panelFields.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Management";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeeName.Location = new System.Drawing.Point(20, 60);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.lblEmployeeName.Size = new System.Drawing.Size(310, 28);
            this.lblEmployeeName.Text = "Employee Name *";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmployeeName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmployeeName.Location = new System.Drawing.Point(20, 88);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(310, 30);
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.Location = new System.Drawing.Point(20, 118);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.lblUsername.Size = new System.Drawing.Size(310, 28);
            this.lblUsername.Text = "Username *";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(20, 146);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(310, 30);
            // 
            // lblPassword
            // 
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.Location = new System.Drawing.Point(20, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.lblPassword.Size = new System.Drawing.Size(310, 28);
            this.lblPassword.Text = "Password * (leave blank when editing to keep current)";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(20, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(310, 30);
            // 
            // lblPosition
            // 
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPosition.Location = new System.Drawing.Point(20, 234);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.lblPosition.Size = new System.Drawing.Size(310, 28);
            this.lblPosition.Text = "Position *";
            // 
            // cmbPosition
            // 
            this.cmbPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPosition.Location = new System.Drawing.Point(20, 262);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(310, 31);
            // 
            // lblAuthority
            // 
            this.lblAuthority.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAuthority.Location = new System.Drawing.Point(20, 293);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.lblAuthority.Size = new System.Drawing.Size(310, 28);
            this.lblAuthority.Text = "Authority *";
            // 
            // cmbAuthority
            // 
            this.cmbAuthority.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAuthority.Location = new System.Drawing.Point(20, 321);
            this.cmbAuthority.Name = "cmbAuthority";
            this.cmbAuthority.Size = new System.Drawing.Size(310, 31);
            // 
            // lblPhone
            // 
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.Location = new System.Drawing.Point(20, 352);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.lblPhone.Size = new System.Drawing.Size(310, 28);
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(20, 380);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 30);
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(20, 410);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.lblEmail.Size = new System.Drawing.Size(310, 28);
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(20, 438);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 30);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(20, 478);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelButtons.Size = new System.Drawing.Size(310, 55);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Size = new System.Drawing.Size(70, 35);
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
            this.btnEdit.Size = new System.Drawing.Size(70, 35);
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
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Size = new System.Drawing.Size(70, 35);
            this.btnClear.Text = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(350, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20);
            this.panelTop.Size = new System.Drawing.Size(630, 80);
            this.panelTop.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(20, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(155, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Employees:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(180, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(430, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvEmployees.ColumnHeadersHeight = 40;
            this.dgvEmployees.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvEmployees.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.dgvEmployees.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.Location = new System.Drawing.Point(350, 80);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 35;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(630, 550);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFields);
            this.Name = "EmployeeForm";
            this.Text = "Employee Management";
            this.panelFields.ResumeLayout(false);
            this.panelFields.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelFields;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.ComboBox cmbAuthority;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}
