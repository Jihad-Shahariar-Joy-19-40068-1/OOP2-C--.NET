using Inventory_Management_System_I_.Data_Acessss_Layer;
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
            //ProductDataAccess productDataAccess = new ProductDataAccess();
            //listOfProductGridView.DataSource = productDataAccess.GetProducts();
            
            UpdateGridView();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            addCategoryComboBox.DataSource = categoryDataAccess.GetCategoryNames();
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
            
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            //need data validation...
            ProductDataAccess productDataAccess = new ProductDataAccess();
            //if (productDataAccess.CreateProduct(addProductNameTextBox.Text,Convert.ToDouble(addPriceTextBox.Text),Convert.ToInt32(addQuantityNumericUpDown.Text)))
            //{
            //    MessageBox.Show("New Product Created");
            //    UpdateGridView();
            //    ClearFields();
            //}
            //else
            //{
             //   MessageBox.Show("Error in creating");
             //   ClearFields();
            //}
        }
    }
}
