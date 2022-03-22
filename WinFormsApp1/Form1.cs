using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = "Hello";
            MessageBox.Show(textBox1.Text + textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBox2.Text);
        }
    }
}
