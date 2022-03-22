using ChefsFoodManagement.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefsFoodManagement.Presentation_Layer
{
    public partial class FoodChart : Form
    {
        public FoodChart()
        {
            InitializeComponent();
        }

        private void FoodChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Red;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.BackColor = Color.Transparent;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManageFood manageFood = new ManageFood();
            manageFood.Show();
            this.Hide();
        }

        private void FoodChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_OOP2_I_DataSet.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this._OOP2_I_DataSet.Foods);

        }
    }
}
