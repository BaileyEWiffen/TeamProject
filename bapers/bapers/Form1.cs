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
    
    public partial class Form1 : Form
    {
       
        private string server;
        private string database;
        private string uid;
        private string password;

        public Form1()
        {
            InitializeComponent();
           


        }

        private void BT_enter_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "bapers";
            uid = "root";
            password = "network";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            MessageBox.Show("Connection Open  !");
            connection.Close();


        }
    }
}
