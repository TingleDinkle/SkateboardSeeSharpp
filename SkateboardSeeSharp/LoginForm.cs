using System;
using System.Windows.Forms;
// DB: Uncomment these when database is connected
// using SkateboardSeeSharp.DAL;
using SkateboardSeeSharp.Models;

namespace SkateboardSeeSharp
{
    public partial class LoginForm : Form
    {
        // DB: Uncomment when database is connected
        // private readonly EmployeeDAL _employeeDAL = new EmployeeDAL();
        private int _loginAttempts = 0;
        private const int MaxAttempts = 5;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterDemoMode()
        {
            Employee demoEmployee = new Employee
            {
                EmployeeID = "EMP0001",
                EmployeeName = "Demo Admin",
                Position = "Admin",
                Authority = "Admin",
                Username = "admin",
                Password = "",
                PhoneNumber = "0123456789",
                Email = "admin@jessesdelight.vn"
            };

            SessionManager.Login(demoEmployee);
            OpenDashboard();
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

            // DB: UNCOMMENT THIS BLOCK WHEN DATABASE IS CONNECTED
            // Replace the demo mode call below with actual DB authentication
            /*
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
            */

            // DEMO: For now, any login goes to demo mode
            EnterDemoMode();
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
