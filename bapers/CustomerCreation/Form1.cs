using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCreation
{
    public partial class CustomerCreation : Form
    {
        public CustomerCreation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text =="" || textBox4.Text== "")
            {
                MessageBox.Show("One or more fields not completed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                string email = textBox3.Text;
                string phoneNumber = textBox4.Text;
                MessageBox.Show("Customer Successfully Created", "Customer Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
    
}
