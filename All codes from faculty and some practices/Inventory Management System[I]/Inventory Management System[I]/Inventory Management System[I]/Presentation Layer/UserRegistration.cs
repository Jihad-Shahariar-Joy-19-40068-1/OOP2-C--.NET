using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Inventory_Management_System_I_.Data_Access_Layer;
using Inventory_Management_System_I_.Presentation_Layer;

namespace User_Registration_I_
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termsCheckBox_Click(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked == true)
            {
                submitButton.Enabled = true;
            }
            else
                submitButton.Enabled = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTime.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked==false && femaleRadioButton.Checked==false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else
            {
                if(passwordTextBox.Text!=confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    //string name, username, password, email, dateOfBirth, gender, bloodGroup;
                    //name = nameTextBox.Text;
                    //username = usernameTextBox.Text;
                    //password = passwordTextBox.Text;
                    //email = emailTextBox.Text;
                    //dateOfBirth = dateOfBirthDateTime.Text;
                    User user = new User();
                    user.Name = nameTextBox.Text;
                    user.Username = usernameTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.Email = emailTextBox.Text;
                    user.DateOfBirth = dateOfBirthDateTime.Text;
                    if (maleRadioButton.Checked)
                    {
                        //gender = "Male";
                        user.Gender = "Male";
                    }
                    else
                        //gender = "Female";
                        user.Gender = "Female";
                    //bloodGroup = bloodGroupComboBox.Text;
                    user.BloodGroup = bloodGroupComboBox.Text;
                    //Output output = new Output(name, username, password, email, dateOfBirth, gender, bloodGroup);
                    //Output output = new Output(user);


                    UserDataAccess userDataAccess = new UserDataAccess();
                    
                    if(userDataAccess.UserRegister(user))
                    {
                        MessageBox.Show("User added");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }
                    
                }
            }
        }

        
    }
}
