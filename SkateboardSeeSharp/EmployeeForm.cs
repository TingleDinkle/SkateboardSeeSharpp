using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SkateboardSeeSharp.DAL;
using SkateboardSeeSharp.Models;

namespace SkateboardSeeSharp
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeDAL _employeeDAL = new EmployeeDAL();
        private string _selectedEmployeeId = null;

        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployees();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            cmbPosition.Items.Clear();
            cmbPosition.Items.AddRange(new object[] { "Admin", "Shop Manager", "Sales Staff", "Warehouse Staff" });

            cmbAuthority.Items.Clear();
            cmbAuthority.Items.AddRange(new object[] { "Admin", "Sales", "Warehouse" });
        }

        private void LoadEmployees()
        {
            try
            {
                DataTable dt = _employeeDAL.GetAll();
                dgvEmployees.DataSource = dt;
                dgvEmployees.ReadOnly = true;
                dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmployees.AllowUserToAddRows = false;
                dgvEmployees.AllowUserToDeleteRows = false;

                if (dgvEmployees.Columns.Contains("Password"))
                {
                    dgvEmployees.Columns["Password"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            _selectedEmployeeId = null;
            txtEmployeeName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cmbPosition.SelectedIndex = -1;
            cmbAuthority.SelectedIndex = -1;
            btnAdd.Enabled = true;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("Employee Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_selectedEmployeeId == null && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required for new employees.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Position.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbAuthority.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Authority level.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    MessageBox.Show("Invalid email format.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                if (_employeeDAL.UsernameExists(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Employee emp = new Employee
                {
                    EmployeeID = _employeeDAL.GetNextEmployeeId(),
                    EmployeeName = txtEmployeeName.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text,
                    Position = cmbPosition.SelectedItem.ToString(),
                    Authority = cmbAuthority.SelectedItem.ToString(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                if (_employeeDAL.Insert(emp))
                {
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId == null)
            {
                MessageBox.Show("Please select an employee to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateFields()) return;

            try
            {
                if (_employeeDAL.UsernameExists(txtUsername.Text.Trim(), _selectedEmployeeId))
                {
                    MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Employee emp = new Employee
                {
                    EmployeeID = _selectedEmployeeId,
                    EmployeeName = txtEmployeeName.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text,
                    Position = cmbPosition.SelectedItem.ToString(),
                    Authority = cmbAuthority.SelectedItem.ToString(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                bool updatePassword = !string.IsNullOrWhiteSpace(txtPassword.Text);
                if (_employeeDAL.Update(emp, updatePassword))
                {
                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedEmployeeId == null)
            {
                MessageBox.Show("Please select an employee to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_employeeDAL.Delete(_selectedEmployeeId))
                    {
                        MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployees();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                _selectedEmployeeId = row.Cells["Employee_ID"].Value.ToString();
                txtEmployeeName.Text = row.Cells["Employee_Name"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Clear(); // Don't fill password
                cmbPosition.SelectedItem = row.Cells["Position"].Value.ToString();
                cmbAuthority.SelectedItem = row.Cells["Authority"].Value.ToString();
                txtPhone.Text = row.Cells["Phone_Number"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            }
        }
    }
}
