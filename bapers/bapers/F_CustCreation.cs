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
        private string user;
        private cust p = new cust();
        MySqlDataReader dataReader;
        DB_Connect db = new DB_Connect();

        public F_CustCreation(string u)
        {
            InitializeComponent();
            user = u;
        }


        private void F_CustCreation_Load(object sender, EventArgs e)
        {
            if (user != "")
            {
                string sql = "SELECT account_number, customer_name,contact_name,address,phone,valued_customer from customer where contact_name = @val0;";
                object[] o = { user };
                dataReader = db.query(sql, o);
                while (dataReader.Read())
                {
                    p.ac = dataReader.GetValue(0).ToString();
                    p.CuName = dataReader.GetValue(1).ToString();
                    p.CoName = dataReader.GetValue(2).ToString();
                    p.address = dataReader.GetValue(3).ToString();
                    p.phone = dataReader.GetValue(4).ToString();
                    p.val = Convert.ToInt32(dataReader.GetValue(5));
                }
                db.close();
                dataReader.Dispose();

            }
            txtFullName.Text = p.CuName;
            txtConName.Text = p.CoName;
            txtAddress.Text = p.address;
            txtPhoneNum.Text = p.phone;
            cbValuedCustomer.Checked = Convert.ToBoolean(p.val);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (user != "")
            {
                String sql = "UPDATE customer set customer_name = @val0 ,contact_name = @val1 ,address = @val2,phone = @val3 where account_number = @val4;";
                object[] o = { txtFullName.Text, txtConName.Text, txtAddress.Text, txtPhoneNum.Text, p.ac };
                db.query(sql, o);
                db.close();
                this.Close();

            }
            else
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

                    string sql = "INSERT INTO customer VALUES ('" + accountNum + "','" + fullName + "','" + conName + "','" + address + "','" + phone + "',null,'" + valuedCustomer + "',null);";//the sql statement to insert the data
                    string connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";//the connection string 

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
}
public class cust
{
    public string CuName { get; set; }
    public string CoName { get; set; }
    public string address { get; set; }
    public string phone { get; set; }
    public int val { get; set; }
    public string ac { get; set; }

}

