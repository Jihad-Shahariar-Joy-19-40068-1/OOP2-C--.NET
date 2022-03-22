using Inventory_Management_System_I_.Data_Access_Layer;
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
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void ManageProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            addCategoryComboBox.DataSource = categoryDataAccess.GetCategoryNames();
            categoryDataAccess = new CategoryDataAccess();
            updateCategoryIdComboBox.DataSource = categoryDataAccess.GetCategoryNames();

        }
        void UpdateGridView()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            listOfProductGridView.DataSource = productDataAccess.GetProducts();
        }
        void ClearFields()
        {
            addProductNameTextBox.Text = string.Empty;
            addPriceTextBox.Text = string.Empty;
            addQuantityNumericUpDown.Text = string.Empty;
            updateProductIdTextBox.Text = string.Empty;
            updateProductNameTextBox.Text = string.Empty;
            updatePriceTextBox.Text = string.Empty;
            updateQuantotyNumericUpDown.Text = string.Empty;
            deleteProductIdTextBox.Text = string.Empty;

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(addCategoryComboBox.Text).CategoryId;
            if (productDataAccess.CreateProduct(addProductNameTextBox.Text, Convert.ToDouble(addPriceTextBox.Text), Convert.ToInt32(addQuantityNumericUpDown.Text),categoryId))
            {
                MessageBox.Show("New product created");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in creating");
                ClearFields();
            }
        }
        int categoryId;
        private void listOfProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            updateProductIdTextBox.Text = listOfProductGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateProductNameTextBox.Text = listOfProductGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updatePriceTextBox.Text = listOfProductGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateQuantotyNumericUpDown.Text = listOfProductGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            categoryId=(int) listOfProductGridView.Rows[e.RowIndex].Cells[4].Value;
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            string categoryName = categoryDataAccess.GetCategoryById(categoryId).CategoryName;
            updateCategoryIdComboBox.Text = categoryName;
            deleteProductIdTextBox.Text= listOfProductGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryByName(updateCategoryIdComboBox.Text).CategoryId;
            if (productDataAccess.UpdateProduct(Convert.ToInt32(updateProductIdTextBox.Text), updateProductNameTextBox.Text, Convert.ToDouble(updatePriceTextBox.Text), Convert.ToInt32(updateQuantotyNumericUpDown.Text), categoryId))
            {
                MessageBox.Show("Product updated");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
                ClearFields();
            }
        }

      

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            if (productDataAccess.DeleteProduct(Convert.ToInt32(deleteProductIdTextBox.Text)))
            {
                MessageBox.Show("Product deleted");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in deleting");
                ClearFields();
            }
        }

        private void searchProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            searchProductDataGridView.DataSource = productDataAccess.GetProductListByNames(searchProductNameTextBox.Text);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
