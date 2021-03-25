using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bapers
{
    public partial class F_CustCreation : Form


    {
        private string server = "localhost";
        private string database = "bapers";
        private string uid = "root";
        private string password = "network";

        public F_CustCreation()
        {
            InitializeComponent();
        }


        private void F_CustCreation_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtConName.Text == "" || txtAddress.Text == "" || txtPhoneNum.Text == "")//checks all boxes are filled
            {
                MessageBox.Show("One or more fields not completed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string accountNum, fullName, conName, address, phone;
                int valuedCustomer;
                fullName = txtFullName.Text;
                conName = txtConName.Text;
                address = txtAddress.Text;
                phone = txtPhoneNum.Text;
                accountNum = phone.Substring(phone.Length - 3) + fullName.Substring(0, 3);
                if (cbValuedCustomer.Checked)
                {
                    valuedCustomer = 1;
                }
                else
                {
                    valuedCustomer = 0;
                }
                // stores the entered information into variables
                MySqlConnection connection;             
                MySqlCommand command;

                string sql = "INSERT INTO customer (accountNumber, customerName, contactName, address, phone, valuedCustomer) VALUES ('"+accountNum+"','" + fullName+"','"+conName+"','"+address+"','"+phone+"','"+valuedCustomer+"');";//the sql statement to insert the data
                string connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password+";";//the connection string 
                
                connection = new MySqlConnection(connectionString);
                try//attmepts to connect to the database and then excute the sql command
                {
                    connection.Open();
                    command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();  
                    connection.Close();
                    MessageBox.Show("Customer Successfully Created", "Customer Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)//displays an error message if any part of the above code fails
                {
                    MessageBox.Show("Connection failed");
                }


            }
        }
    }
}

