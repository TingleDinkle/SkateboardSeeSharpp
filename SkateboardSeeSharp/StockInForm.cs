using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
// DB: Uncomment when database is connected
// using SkateboardSeeSharp.DAL;

namespace SkateboardSeeSharp
{
    public partial class StockInForm : Form
    {
        // DB: Uncomment when database is connected
        // private readonly StockInDAL _stockInDAL = new StockInDAL();
        // private readonly ProductDAL _productDAL = new ProductDAL();
        private DataTable _importLines;
        private string _selectedProductId = null;

        public StockInForm()
        {
            InitializeComponent();
            InitializeImportLines();
            // DB: Uncomment when database is connected
            // LoadProducts();
            // LoadCategories();
        }

        private void InitializeImportLines()
        {
            _importLines = new DataTable();
            _importLines.Columns.Add("Product_ID", typeof(string));
            _importLines.Columns.Add("Product_Name", typeof(string));
            _importLines.Columns.Add("Import_Quantity", typeof(int));
            _importLines.Columns.Add("Import_Price", typeof(decimal));
            dgvImportLines.DataSource = _importLines;
        }

        private void LoadProducts()
        {
            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            try
            {
                DataTable dt = _stockInDAL.GetAllProducts();
                dgvProducts.DataSource = dt;

                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["Inventory_Quantity"].Value != null)
                    {
                        int qty = Convert.ToInt32(row.Cells["Inventory_Quantity"].Value);
                        if (qty < 5)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(133, 100, 4);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void LoadCategories()
        {
            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            try
            {
                DataTable dt = _stockInDAL.GetCategories();
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "Category_Name";
                cmbCategory.ValueMember = "Category_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void ClearFields()
        {
            _selectedProductId = null;
            txtProductId.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            nudStock.Value = 0;
            txtDescription.Clear();
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            btnAddProduct.Text = "ADD PRODUCT";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            try
            {
                if (_selectedProductId == null)
                {
                    string newId = _productDAL.GetNextProductId();
                    string catId = cmbCategory.SelectedValue?.ToString();
                    if (_productDAL.Insert(newId, txtProductName.Text.Trim(), price, (int)nudStock.Value,
                        txtDescription.Text.Trim(), "", catId))
                    {
                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                        ClearFields();
                    }
                }
                else
                {
                    string catId = cmbCategory.SelectedValue?.ToString();
                    if (_productDAL.Update(_selectedProductId, txtProductName.Text.Trim(), price, (int)nudStock.Value,
                        txtDescription.Text.Trim(), "", catId))
                    {
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            // DEMO: Show success without DB
            string action = _selectedProductId == null ? "added" : "updated";
            MessageBox.Show($"Product {action} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("Please select a product to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
                /*
                try
                {
                    if (_productDAL.Delete(_selectedProductId))
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */

                // DEMO: Show success without DB
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void btnAddToImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name first.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal importPrice;
            if (!decimal.TryParse(txtImportPrice.Text, out importPrice))
            {
                MessageBox.Show("Please enter a valid import price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudImportQty.Value <= 0)
            {
                MessageBox.Show("Please enter a valid import quantity.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string prodId = _selectedProductId ?? "PROD" + (_importLines.Rows.Count + 1).ToString("D4");
            _importLines.Rows.Add(prodId, txtProductName.Text, (int)nudImportQty.Value, importPrice);
        }

        private void btnSaveImport_Click(object sender, EventArgs e)
        {
            if (_importLines.Rows.Count == 0)
            {
                MessageBox.Show("No items in the import list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            try
            {
                string importId = _stockInDAL.GetNextImportId();
                decimal total = 0;
                foreach (DataRow row in _importLines.Rows)
                {
                    total += Convert.ToDecimal(row["Import_Price"]) * Convert.ToInt32(row["Import_Quantity"]);
                }

                if (_stockInDAL.CreateImportOrder(importId, SessionManager.CurrentEmployee.EmployeeID,
                    total, txtImportNotes.Text.Trim(), _importLines))
                {
                    MessageBox.Show($"Import order {importId} saved successfully!\nTotal: {total:N2}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _importLines.Clear();
                    txtImportNotes.Clear();
                    txtImportPrice.Clear();
                    nudImportQty.Value = 1;
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving import order: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            // DEMO: Show success without DB
            decimal demoTotal = 0;
            foreach (DataRow row in _importLines.Rows)
            {
                demoTotal += Convert.ToDecimal(row["Import_Price"]) * Convert.ToInt32(row["Import_Quantity"]);
            }
            string demoImportId = "IMP-" + DateTime.Now.ToString("yyyyMMdd") + "-0001";
            MessageBox.Show($"Import order {demoImportId} saved successfully!\nTotal: {demoTotal:N2}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _importLines.Clear();
            txtImportNotes.Clear();
            txtImportPrice.Clear();
            nudImportQty.Value = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                _selectedProductId = row.Cells["Product_ID"].Value.ToString();
                txtProductId.Text = _selectedProductId;
                txtProductName.Text = row.Cells["Product_Name"].Value.ToString();
                txtPrice.Text = Convert.ToDecimal(row.Cells["Selling_Price"].Value).ToString("N2");
                nudStock.Value = Convert.ToInt32(row.Cells["Inventory_Quantity"].Value);
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";

                string catId = row.Cells["Category_ID"].Value?.ToString();
                if (!string.IsNullOrEmpty(catId))
                {
                    cmbCategory.SelectedValue = catId;
                }

                int qty = Convert.ToInt32(row.Cells["Inventory_Quantity"].Value);
                if (qty <= 0)
                    cmbStatus.SelectedIndex = 1;
                else
                    cmbStatus.SelectedIndex = 0;

                btnAddProduct.Text = "EDIT PRODUCT";
            }
            */
        }
    }
}
