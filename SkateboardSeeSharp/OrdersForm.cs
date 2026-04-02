using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SkateboardSeeSharp.DAL;

namespace SkateboardSeeSharp
{
    public partial class OrdersForm : Form
    {
        private readonly OrderDAL _orderDAL = new OrderDAL();
        private DataTable _orderLines;

        public OrdersForm()
        {
            InitializeComponent();
            InitializeOrderLines();
            LoadCategories();
            LoadProducts();
            LoadCustomers();
        }

        private void InitializeOrderLines()
        {
            _orderLines = new DataTable();
            _orderLines.Columns.Add("Product_ID", typeof(string));
            _orderLines.Columns.Add("Product_Name", typeof(string));
            _orderLines.Columns.Add("Unit_Price", typeof(decimal));
            _orderLines.Columns.Add("Quantity", typeof(int));
            _orderLines.Columns.Add("Subtotal", typeof(decimal));
            dgvOrderLines.DataSource = _orderLines;
        }

        private void LoadCategories()
        {
            try
            {
                DataTable dt = _orderDAL.GetCategories();
                DataRow allRow = dt.NewRow();
                allRow["Category_ID"] = "";
                allRow["Category_Name"] = "-- All Categories --";
                dt.Rows.InsertAt(allRow, 0);

                cmbFilterCategory.DataSource = dt;
                cmbFilterCategory.DisplayMember = "Category_Name";
                cmbFilterCategory.ValueMember = "Category_ID";

                DataTable dtEntry = _orderDAL.GetCategories();
                cmbOrderCategory.DataSource = dtEntry;
                cmbOrderCategory.DisplayMember = "Category_Name";
                cmbOrderCategory.ValueMember = "Category_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                string catId = cmbFilterCategory.SelectedValue?.ToString() ?? "";
                string search = txtSearch.Text.Trim();
                DataTable dt = _orderDAL.GetProductsByFilter(catId, search);
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                DataTable dt = _orderDAL.GetCustomers();
                DataRow walkIn = dt.NewRow();
                walkIn["Customer_ID"] = "";
                walkIn["Customer_Name"] = "-- Walk-in Customer --";
                dt.Rows.InsertAt(walkIn, 0);

                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "Customer_Name";
                cmbCustomer.ValueMember = "Customer_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cmbOrderCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string catId = cmbOrderCategory.SelectedValue?.ToString();
                if (!string.IsNullOrEmpty(catId))
                {
                    DataTable dt = _orderDAL.GetProductsByCategory(catId);
                    cmbProductId.DataSource = dt;
                    cmbProductId.DisplayMember = "Product_ID";
                    cmbProductId.ValueMember = "Product_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductId.SelectedItem != null && cmbProductId.DataSource is DataTable dt)
            {
                DataRowView row = cmbProductId.SelectedItem as DataRowView;
                if (row != null)
                {
                    txtProductName.Text = row["Product_Name"].ToString();
                    txtPrice.Text = Convert.ToDecimal(row["Selling_Price"]).ToString("N2");
                    nudQuantity.Maximum = Convert.ToInt32(row["Inventory_Quantity"]);
                    nudQuantity.Value = 1;
                }
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please select a product first.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productId = "PROD" + (_orderLines.Rows.Count + 1).ToString("D4");
            string productName = txtProductName.Text;
            decimal unitPrice = 0;
            decimal.TryParse(txtPrice.Text, out unitPrice);
            int quantity = (int)nudQuantity.Value;
            decimal subtotal = unitPrice * quantity;

            _orderLines.Rows.Add(productId, productName, unitPrice, quantity, subtotal);
            CalculateTotal();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrderLines.SelectedRows.Count > 0)
            {
                int rowIndex = dgvOrderLines.SelectedRows[0].Index;
                _orderLines.Rows.RemoveAt(rowIndex);
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Please select an order line to remove.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            _orderLines.Clear();
            CalculateTotal();
            txtDiscount.Text = "0";
            txtAmountTendered.Text = "0";
            lblChangeDue.Text = "0.00";
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in _orderLines.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            lblTotalPrice.Text = total.ToString("N2");
            CalculateChange();
        }

        private void CalculateChange()
        {
            decimal total = 0;
            decimal.TryParse(lblTotalPrice.Text, out total);

            decimal discount = 0;
            decimal.TryParse(txtDiscount.Text, out discount);

            decimal tendered = 0;
            decimal.TryParse(txtAmountTendered.Text, out tendered);

            decimal finalTotal = total - discount;
            decimal change = tendered - finalTotal;
            lblChangeDue.Text = change.ToString("N2");
            lblFinalTotal.Text = finalTotal.ToString("N2");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void txtAmountTendered_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            if (_orderLines.Rows.Count == 0)
            {
                MessageBox.Show("No items in the order.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal tendered = 0;
            decimal.TryParse(txtAmountTendered.Text, out tendered);
            decimal finalTotal = 0;
            decimal.TryParse(lblFinalTotal.Text, out finalTotal);

            if (tendered < finalTotal)
            {
                MessageBox.Show("Amount tendered is less than the total.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string orderId = _orderDAL.GetNextOrderId();
                string customerId = cmbCustomer.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(customerId)) customerId = null;

                decimal discount = 0;
                decimal.TryParse(txtDiscount.Text, out discount);

                decimal totalAmount = 0;
                decimal.TryParse(lblTotalPrice.Text, out totalAmount);

                if (_orderDAL.CreateOrder(orderId, customerId, SessionManager.CurrentEmployee.EmployeeID,
                    totalAmount, discount, "", _orderLines))
                {
                    string receipt = $"========== RECEIPT ==========\n";
                    receipt += $"Jesse's Delight Skateboard Shop\n";
                    receipt += $"Order: {orderId}\n";
                    receipt += $"Date: {DateTime.Now:yyyy-MM-dd HH:mm}\n";
                    receipt += $"Cashier: {SessionManager.CurrentEmployee.EmployeeName}\n";
                    receipt += $"-------------------------------\n";

                    foreach (DataRow row in _orderLines.Rows)
                    {
                        receipt += $"{row["Product_Name"]} x{row["Quantity"]} @ {Convert.ToDecimal(row["Unit_Price"]):N2} = {Convert.ToDecimal(row["Subtotal"]):N2}\n";
                    }

                    receipt += $"-------------------------------\n";
                    receipt += $"Subtotal:  {totalAmount:N2}\n";
                    receipt += $"Discount:  {discount:N2}\n";
                    receipt += $"Total:     {finalTotal:N2}\n";
                    receipt += $"Tendered:  {tendered:N2}\n";
                    receipt += $"Change:    {(tendered - finalTotal):N2}\n";
                    receipt += $"=============================\n";
                    receipt += $"Thank you for shopping at\nJesse's Delight!";

                    MessageBox.Show(receipt, "Receipt - Order Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _orderLines.Clear();
                    CalculateTotal();
                    txtDiscount.Text = "0";
                    txtAmountTendered.Text = "0";
                    LoadProducts(); // Refresh products to show updated stock
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtProductName.Text = row.Cells["Product_Name"].Value.ToString();
                txtPrice.Text = Convert.ToDecimal(row.Cells["Selling_Price"].Value).ToString("N2");
                nudQuantity.Maximum = Convert.ToInt32(row.Cells["Inventory_Quantity"].Value);
                nudQuantity.Value = 1;
            }
        }
    }
}
