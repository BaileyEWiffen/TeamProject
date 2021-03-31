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
       //database connect info
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
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pw + ";";//creating the connection string

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            MessageBox.Show("Connection Open!");//testing the connection
            connection.Close();


        }

        private void BT_input_Click(object sender, EventArgs e)//makes sure email and password are valid
        {
            DB_Connect db = new DB_Connect();
            String sql, output = "";
            MySqlDataReader dataReader;

            sql = "SELECT role, UserName FROM user WHERE UserName= @val0 AND password= @val1;";
            object[] o = new object[2];
            o[0] = TB_email.Text;
            o[1] = TB_password.Text;

            dataReader = db.query(sql,o);

            int dup = 0;
            while (dataReader.Read())//checks how many instances of the username and password there are in the database
            {
                output = Convert.ToString(dataReader.GetValue(0))+", "+Convert.ToString(dataReader.GetValue(1));
                dup += 1;
            }

            db.close();
    
            dataReader.Dispose();
           

            if(dup == 1)
            {
                //MessageBox.Show("Access Granted, " + output + "!");
                F_Home fh = new F_Home(output);
                this.Hide();
                fh.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Access Denied"); ;
            }





        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
