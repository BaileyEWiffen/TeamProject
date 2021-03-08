using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bapers
{
    
    public partial class F_Login : Form
    {
       
        private string server = "localhost";
        private string database = "bapers";
        private string uid  = "root";
        private string pw = "network";

        public F_Login()
        {
            InitializeComponent();
           


        }

        private void BT_enter_Click(object sender, EventArgs e)
        {
           
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pw + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            MessageBox.Show("Connection Open!");
            connection.Close();


        }

        private void BT_input_Click(object sender, EventArgs e)
        {
            
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pw + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, output = "";

            sql = "SELECT role FROM user WHERE email= '"+TB_email.Text+"' AND password= '"+TB_password.Text+"';";
            command = new MySqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            int dup = 0;
            while (dataReader.Read())//checks how many instances of the username and password there are in the database
            {
                output = Convert.ToString(dataReader.GetValue(0));
                dup += 1;
            }
            connection.Close();

            if(dup == 1)
            {
                MessageBox.Show("Access Granted, " + output + "!");
            }
            else
            {
                MessageBox.Show("Access Denied"); ;
            }





        }
    }
}
