using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management.Database;
using Employee_Management.Models;

namespace Employee_Management.Forms
{
    /// <summary>
    /// Form management boundary managing inventory asset categories.
    /// Operates CRUD routing commands downstream into the database layer infrastructure.
    /// </summary>
    public partial class CategoryForm : Form
    {
        // Tracks the actively selected unique index identifier across grid rows
        private int selectedId = 0;

        public CategoryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initial load event. Populates structural collections upon visual activation.
        /// </summary>
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Extracts records from the repository and binds data maps natively to display grids.
        /// </summary>
        private void LoadData()
        {
            try
            {
                CategoryRepository repo = new CategoryRepository();
                dataGridView1.DataSource = repo.GetAllCategories();

                // Clean up headers professionally
                if (dataGridView1.Columns["Id"] != null) dataGridView1.Columns["Id"].HeaderText = "Category ID";
                if (dataGridView1.Columns["Name"] != null) dataGridView1.Columns["Name"].HeaderText = "Category Name";
                if (dataGridView1.Columns["Description"] != null) dataGridView1.Columns["Description"].HeaderText = "Description";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load catalog classifications: " + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Processes and passes new category profiles down to storage parameters.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Category cat = new Category
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };

            CategoryRepository repo = new CategoryRepository();
            repo.AddCategory(cat);

            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearFields();
        }

        /// <summary>
        /// Modifies data indices assigned to existing operational identities.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a category from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Category cat = new Category
            {
                Id = selectedId,
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };

            CategoryRepository repo = new CategoryRepository();
            repo.UpdateCategory(cat);

            MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearFields();
        }

        /// <summary>
        /// Purges target identity structures completely out of storage schemas.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a category from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CategoryRepository repo = new CategoryRepository();
                repo.DeleteCategory(selectedId);

                MessageBox.Show("Category deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
        }

        /// <summary>
        /// Translates horizontal row selection data targets cleanly back out to input control layouts.
        /// </summary>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
            }
        }

        /// <summary>
        /// Flushes data values cleanly out of control text arrays.
        /// </summary>
        private void ClearFields()
        {
            txtName.Clear();
            txtDescription.Clear();
            selectedId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /* * DESIGNER COMPATIBILITY STUB
         * Keeping this explicit method boundary target mapped safely here to 
         * protect background compilation schemas from failing layout loads.
         */
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Redirect accidental double-clicked designer mappings to the true operational validation sequence
            btnAdd_Click(sender, e);
        }
    }
}