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
    public partial class Output : Form
    {
        public Output(User user)
        {
            InitializeComponent();
            nameLabel.Text += user.Name;
            usernameLabel.Text += user.Username;
            passwordLabel.Text += user.Password;
            emailLabel.Text += user.Email;
            dateOfBirthLabel.Text += user.DateOfBirth;
            genderLabel.Text += user.Gender;
            bloodGroupLabel.Text += user.BloodGroup;
        }

        public Output()
        {
            InitializeComponent();
            //nameLabel.Text += user.Name;
            //usernameLabel.Text += user.Username;
            //passwordLabel.Text += user.Password;
            //emailLabel.Text += user.Email;
            //dateOfBirthLabel.Text += user.DateOfBirth;
            //genderLabel.Text += user.Gender;
            //bloodGroupLabel.Text += user.BloodGroup;
        }

        private void Output_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text=="")
            {
                MessageBox.Show("Please give an Id");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2[I]"].ConnectionString);
                connection.Open();

                string sql = "SELECT * FROM Users WHERE Id="+Convert.ToInt32(idTextBox.Text);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                 
                if(reader.HasRows)
                {
                    reader.Read();
                    nameLabel.Text ="Name:" +reader["Name"].ToString();
                    usernameLabel.Text ="Username:" +reader["Username"].ToString();
                    passwordLabel.Text ="Password:" +reader["Password"].ToString();
                    emailLabel.Text ="Email:" +reader["Email"].ToString();
                    dateOfBirthLabel.Text ="DateOfBirth:" +reader["DateOfBirth"].ToString();
                    genderLabel.Text ="Gender" +reader["Gender"].ToString();
                    bloodGroupLabel.Text ="BloodGroup:" +reader["BloodGroup"].ToString();
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
        }
    }
}
