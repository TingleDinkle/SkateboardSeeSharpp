using System;
using System.Windows.Forms;
using SkateboardSeeSharp.DAL;
using SkateboardSeeSharp.Models;

namespace SkateboardSeeSharp
{
    public partial class LoginForm : Form
    {
        private readonly EmployeeDAL _employeeDAL = new EmployeeDAL();
        private int _loginAttempts = 0;
        private const int MaxAttempts = 5;

        public LoginForm()
        {
            InitializeComponent();
        }



        private void OpenDashboard()
        {
            panelLoading.Visible = false;
            MainDashboard dashboard = new MainDashboard();
            this.Hide();
            dashboard.FormClosed += (s, args) =>
            {
                if (SessionManager.IsLoggedIn)
                {
                    Application.Exit();
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    lblError.Text = "";
                    _loginAttempts = 0;
                    btnLogin.Enabled = true;
                    this.Show();
                }
            };
            dashboard.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_loginAttempts >= MaxAttempts)
            {
                lblError.Text = "Account locked. Too many failed attempts. Please restart the application.";
                btnLogin.Enabled = false;
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                panelLoading.Visible = true;
                Application.DoEvents();

                Employee employee = _employeeDAL.GetByUsername(username);

                if (employee != null && PasswordHelper.VerifyPassword(password, employee.Password))
                {
                    SessionManager.Login(employee);
                    OpenDashboard();
                }
                else
                {
                    _loginAttempts++;
                    int remaining = MaxAttempts - _loginAttempts;
                    lblError.Text = $"Invalid username or password. {remaining} attempt(s) remaining.";
                    panelLoading.Visible = false;

                    if (_loginAttempts >= MaxAttempts)
                    {
                        btnLogin.Enabled = false;
                        lblError.Text = "Account locked. Too many failed attempts. Please restart the application.";
                    }
                }
            }
            catch (Exception ex)
            {
                panelLoading.Visible = false;
                MessageBox.Show("Database connection error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
