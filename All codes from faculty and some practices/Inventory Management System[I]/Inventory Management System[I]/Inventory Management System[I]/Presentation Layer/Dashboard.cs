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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory();
            manageCategory.Show();
            this.Hide();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct();
            manageProduct.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
