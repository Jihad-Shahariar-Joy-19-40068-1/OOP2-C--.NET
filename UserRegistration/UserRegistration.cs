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

namespace UserRegistration
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
                MessageBox.Show("Confirm password cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTime.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked==false && FemaleRadioButton.Checked==false)
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
                    MessageBox.Show("Password and Confirm password does not match");
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
                    {
                        //gender = "Female";
                        user.Gender = "Female";
                    }
                    //bloodGroup = bloodGroupComboBox.Text;
                    user.BloodGroup = bloodGroupComboBox.Text;

                    //Output output = new Output(name, username, password, email, dateOfBirth, gender, bloodGroup);
                    //Output output = new Output(user);

                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[I]"].ConnectionString);
                    connection.Open();

                    string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES('"+user.Name+"','"+user.Username+"','"+user.Password+"','"+user.Email+"','"+user.DateOfBirth+"','"+user.Gender+"','"+user.BloodGroup+"')";
                    SqlCommand command = new SqlCommand(sql,connection);
                    int result=command.ExecuteNonQuery();
                    if (result> 0)
                    {
                        MessageBox.Show("User added");
                        Output output = new Output();
                        output.Show();
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
