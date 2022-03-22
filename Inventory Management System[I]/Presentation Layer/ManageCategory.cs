using Inventory_Management_System_I_.Data_Acessss_Layer;
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
            //CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            //listOfCategoriesGridView.DataSource = categoryDataAccess.GetCategories();
            GridViewUpdate();
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
                MessageBox.Show("New Category Added");
                GridViewUpdate();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in Adding");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(updateCategoryIdTextBox.Text=="")
            {
                MessageBox.Show("Please give a category ID");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
                int id = Convert.ToInt32(updateCategoryIdTextBox.Text);
                Category category = categoryDataAccess.GetCategoryById(id);
                if(category==null)
                {
                    MessageBox.Show("Category Not Available");
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
                MessageBox.Show("Category Updated");
                GridViewUpdate();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in Updating");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();

            int id = Convert.ToInt32(deleteCategoryIdTextBox.Text);
            Category category = categoryDataAccess.GetCategoryById(id);
            if (category == null)
            {
                MessageBox.Show("Category Not Available");
                ClearFields();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    categoryDataAccess = new CategoryDataAccess();
                    if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCategoryIdTextBox.Text)))
                    {
                        MessageBox.Show("Category Deleted");
                        GridViewUpdate();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error in Deleting");
                    }
                }
            }
        }
    }
}
