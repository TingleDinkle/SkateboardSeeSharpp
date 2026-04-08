using System;
using System.Drawing;
using System.Windows.Forms;

namespace SkateboardSeeSharp
{
    public partial class MainDashboard : Form
    {
        private Button _activeButton = null;

        public MainDashboard()
        {
            InitializeComponent();
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            lblEmployeeName.Text = SessionManager.CurrentEmployee.EmployeeName;
            lblRole.Text = SessionManager.CurrentEmployee.Position;

            string authority = SessionManager.CurrentEmployee.Authority;

            // Admin sees all
            // Sales Staff sees Orders only
            // Warehouse Staff sees Stock In only
            switch (authority)
            {
                case "Admin":
                    // All buttons visible (default)
                    break;
                case "Sales":
                    btnEmployees.Visible = false;
                    btnCategories.Visible = false;
                    btnProducts.Visible = false;
                    btnStockIn.Visible = false;
                    break;
                case "Warehouse":
                    btnEmployees.Visible = false;
                    btnOrders.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void HighlightButton(Button btn)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.FromArgb(44, 62, 80);
                _activeButton.ForeColor = Color.White;
            }
            _activeButton = btn;
            btn.BackColor = Color.FromArgb(0, 123, 255);
            btn.ForeColor = Color.White;
        }

        private void LoadFormInPanel(Form form)
        {
            panelContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HighlightButton(btnEmployees);
            LoadFormInPanel(new EmployeeForm());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCategories);
            LoadFormInPanel(new CategoryForm());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCustomers);
            LoadFormInPanel(new CustomerForm());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            HighlightButton(btnProducts);
            LoadFormInPanel(new StockInForm());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            HighlightButton(btnOrders);
            LoadFormInPanel(new OrdersForm());
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            HighlightButton(btnStockIn);
            LoadFormInPanel(new StockInForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();
                this.Close();
            }
        }
    }
}
