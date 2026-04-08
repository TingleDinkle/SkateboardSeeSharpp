using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SkateboardSeeSharp.DAL;

namespace SkateboardSeeSharp
{
    public partial class ProductsForm : Form
    {
        private readonly ProductDAL _productDAL = new ProductDAL();
        private readonly CategoryDAL _categoryDAL = new CategoryDAL();
        private string _selectedProductId = null;

        public ProductsForm()
        {
            InitializeComponent();
            LoadProducts();
            LoadCategories();
        }

        private void LoadProducts()
        {
            try
            {
                DataTable dt = _productDAL.GetAll();
                dgvProducts.DataSource = dt;
                
                // Hide ID columns or foreign keys visually if needed, but keeping simple for now
                if(dgvProducts.Columns["Product_ID"] != null)
                    dgvProducts.Columns["Product_ID"].HeaderText = "ID";
                if(dgvProducts.Columns["Category_ID"] != null)
                    dgvProducts.Columns["Category_ID"].Visible = false;
                if(dgvProducts.Columns["Product_Image"] != null)
                    dgvProducts.Columns["Product_Image"].Visible = false;

                // Adjust headers
                if(dgvProducts.Columns["Product_Name"] != null) dgvProducts.Columns["Product_Name"].HeaderText = "Product Name";
                if(dgvProducts.Columns["Selling_Price"] != null) dgvProducts.Columns["Selling_Price"].HeaderText = "Price";
                if(dgvProducts.Columns["Inventory_Quantity"] != null) dgvProducts.Columns["Inventory_Quantity"].HeaderText = "Stock";
                if(dgvProducts.Columns["Category_Name"] != null) dgvProducts.Columns["Category_Name"].HeaderText = "Category";

                // Highlight low stock if desired
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["Inventory_Quantity"].Value != null && row.Cells["Inventory_Quantity"].Value != DBNull.Value)
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
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                DataTable dt = _categoryDAL.GetAll();
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "Category_Name";
                cmbCategory.ValueMember = "Category_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            _selectedProductId = null;
            txtProductName.Clear();
            txtPrice.Clear();
            nudStock.Value = 0;
            txtDescription.Clear();
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            btnAdd.Text = "ADD";
            txtSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Product Name, Price, and Category are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string newId = _productDAL.GetNextProductId();
                string catId = cmbCategory.SelectedValue.ToString();
                
                if (_productDAL.Insert(newId, txtProductName.Text.Trim(), price, (int)nudStock.Value, txtDescription.Text.Trim(), null, catId))
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("Please select a product to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Product Name, Price, and Category are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string catId = cmbCategory.SelectedValue.ToString();
                if (_productDAL.Update(_selectedProductId, txtProductName.Text.Trim(), price, (int)nudStock.Value, txtDescription.Text.Trim(), null, catId))
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == null)
            {
                MessageBox.Show("Please select a product to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
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
                    MessageBox.Show("Error deleting product. It may be used in other records.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTxt = txtSearch.Text.Trim();
                DataTable dt = string.IsNullOrEmpty(searchTxt) ? _productDAL.GetAll() : _productDAL.SearchProducts(searchTxt, ""); // Assuming empty category means all
                
                dgvProducts.DataSource = dt;
                
                // Keep highlights when searching
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["Inventory_Quantity"].Value != null && row.Cells["Inventory_Quantity"].Value != DBNull.Value)
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
                // Can ignore or log search errors
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                _selectedProductId = row.Cells["Product_ID"].Value.ToString();
                
                txtProductName.Text = row.Cells["Product_Name"].Value.ToString();
                txtPrice.Text = Convert.ToDecimal(row.Cells["Selling_Price"].Value).ToString("N2");
                nudStock.Value = Convert.ToInt32(row.Cells["Inventory_Quantity"].Value);
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";

                string catId = row.Cells["Category_ID"].Value?.ToString();
                if (!string.IsNullOrEmpty(catId))
                {
                    cmbCategory.SelectedValue = catId;
                }

                btnAdd.Text = "ADD"; // keep text consistent or update
            }
        }
    }
}
