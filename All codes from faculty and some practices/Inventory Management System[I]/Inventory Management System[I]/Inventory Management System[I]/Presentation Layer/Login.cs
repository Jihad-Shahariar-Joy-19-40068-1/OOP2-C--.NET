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
using User_Registration_I_;

namespace Inventory_Management_System_I_.Presentation_Layer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void userRegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginUsernameTextBox.Text=="" && loginPasswordTextBox.Text=="")
            {
                MessageBox.Show("Username and password cannot be empty");
            }
            else if(loginUsernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                UserDataAccess userDataAccess = new UserDataAccess();
                if(userDataAccess.ValidateLogin(loginUsernameTextBox.Text,loginPasswordTextBox.Text))
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
