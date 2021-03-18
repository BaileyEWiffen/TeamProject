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

namespace bapers
{
    public partial class F_CustCreation : Form


    {
        private string server = "localhost";
        private string database = "bapers";
        private string uid = "root";
        private string pw = "network";

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

                string connectionString = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + pw + ";";
                SqlConnection connection = new SqlConnection(connectionString);//opens connection
                SqlCommand cmd = new SqlCommand("sp_insert", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@contact name", txtConName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhoneNum.Text);
                connection.Open();
                int i = cmd.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Customer Successfully Created", "Customer Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
        }
    }
}

