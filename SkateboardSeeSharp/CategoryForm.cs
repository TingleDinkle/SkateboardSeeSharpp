using System;
using System.Data;
using System.Windows.Forms;
// DB: Uncomment when database is connected
// using SkateboardSeeSharp.DAL;

namespace SkateboardSeeSharp
{
    public partial class CategoryForm : Form
    {
        // DB: Uncomment when database is connected
        // private readonly CategoryDAL _categoryDAL = new CategoryDAL();
        private string _selectedCategoryId = null;

        public CategoryForm()
        {
            InitializeComponent();
            // DB: Uncomment when database is connected
            // LoadCategories();
        }

        private void LoadCategories()
        {
            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            try
            {
                DataTable dt = _categoryDAL.GetAll();
                dgvCategories.DataSource = dt;
                dgvCategories.ReadOnly = true;
                dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategories.AllowUserToAddRows = false;
                dgvCategories.AllowUserToDeleteRows = false;
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
            _selectedCategoryId = null;
            txtCategoryName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            try
            {
                string newId = _categoryDAL.GetNextCategoryId();
                if (_categoryDAL.Insert(newId, txtCategoryName.Text.Trim()))
                {
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            // DEMO: Show success without DB
            MessageBox.Show("Category added successfully! (Demo Mode - not saved to database)", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == null)
            {
                MessageBox.Show("Please select a category to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            try
            {
                if (_categoryDAL.Update(_selectedCategoryId, txtCategoryName.Text.Trim()))
                {
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            // DEMO: Show success without DB
            MessageBox.Show("Category updated successfully! (Demo Mode - not saved to database)", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == null)
            {
                MessageBox.Show("Please select a category to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
                /*
                try
                {
                    if (_categoryDAL.Delete(_selectedCategoryId))
                    {
                        MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategories();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */

                // DEMO: Show success without DB
                MessageBox.Show("Category deleted successfully! (Demo Mode - not saved to database)", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DB: UNCOMMENT WHEN DATABASE IS CONNECTED
            /*
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategories.Rows[e.RowIndex];
                _selectedCategoryId = row.Cells["Category_ID"].Value.ToString();
                txtCategoryName.Text = row.Cells["Category_Name"].Value.ToString();
            }
            */
        }
    }
}
