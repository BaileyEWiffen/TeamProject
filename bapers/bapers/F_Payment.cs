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
    public partial class F_Payment : Form
    {
        private string server = "localhost";
        private string database = "bapers";
        private string uid = "root";
        private string password = "network";

        public F_Payment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtCardDigits.Text == "" || txtCusAccNum.Text == "" || cmbPaymentType.Text == "")//checks all boxes are filled
            {
                MessageBox.Show("One or more fields not completed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString, paymentType, cardType, lastDigits, cusAccountNum;
                int paymentID, iD, payment;
                float amount;
                Random rnd = new Random();
                amount = float.Parse(txtAmount.Text);
                paymentType = cmbPaymentType.SelectedItem.ToString();
                cardType = cmbCardType.SelectedItem.ToString();
                lastDigits = txtCardDigits.Text;
                cusAccountNum = txtCusAccNum.Text;
                iD = rnd.Next(1000, 9999);
                payment = (int)amount;
                paymentID = int.Parse(iD.ToString() + payment.ToString());

                try
                {
                    connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    MySqlCommand command;
                    string sql = "";
                    connection.Open();
                    sql = "INSERT INTO payment VALUES ('" + paymentID + "','" + amount + "','" + paymentType + "','" + cardType + "','" + lastDigits + "','" + cusAccountNum + "')";
                    command = new MySqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Payment successfully recorded");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed");
                }
            }
        }

        private void F_Payment_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
