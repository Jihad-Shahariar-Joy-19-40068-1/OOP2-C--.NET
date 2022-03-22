using Inventory_Management_System_I_.Data_Access_Layer;
using Inventory_Management_System_I_.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_I_.Presentation_Layer
{
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void ManageCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            GridViewUpdate();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryWiseProductListComboBox.DataSource = categoryDataAccess.GetCategoryNames();
        }

        void GridViewUpdate()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            listOfCategoriesGridView.DataSource = categoryDataAccess.GetCategories();
        }

        void ClearFields()
        {
            addCategoryNameTextBox.Text = string.Empty;
            updateCategoryIdTextBox.Text = string.Empty;
            updateCategoryNameTextBox.Text = string.Empty;
            deleteCategoryIdTextBox.Text = string.Empty;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if(categoryDataAccess.CreateCategory(addCategoryNameTextBox.Text))
            {
                MessageBox.Show("New category added");
                GridViewUpdate();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in adding");
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(updateCategoryIdTextBox.Text=="")
            {
                MessageBox.Show("Please give a category ID");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                int id =Convert.ToInt32(updateCategoryIdTextBox.Text);
                Category category= categoryDataAccess.GetCategoryById(id);
                if(category==null)
                {
                    MessageBox.Show("Category not available");
                    ClearFields();
                }
                else
                {
                    updateCategoryNameTextBox.Text = category.CategoryName;
                }
                
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.UpdateCategory(Convert.ToInt32(updateCategoryIdTextBox.Text),updateCategoryNameTextBox.Text))
            {
                MessageBox.Show("Category updated");
                GridViewUpdate();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int id = Convert.ToInt32(deleteCategoryIdTextBox.Text);
            Category category = categoryDataAccess.GetCategoryById(id);
            if (category == null)
            {
                MessageBox.Show("Category not available");
                ClearFields();
            }
            else
            {
                DialogResult result= MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    categoryDataAccess = new CategoryDataAccess();
                    if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCategoryIdTextBox.Text)))
                    {
                        MessageBox.Show("Category deleted");
                        GridViewUpdate();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting");
                    }
                }
                
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void categoryWiseProductListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(categoryWiseProductListComboBox.Text).CategoryId;
            ProductDataAccess productDataAccess = new ProductDataAccess();
            categoryWiseProductListGridView.DataSource = productDataAccess.GetProductsByCategoryId(categoryId);
        }
    }
}
