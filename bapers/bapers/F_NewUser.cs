using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bapers
{
    public partial class F_NewUser : Form
    {

        private string server = "localhost";
        private string database = "bapers";
        private string uid = "root";
        private string pw = "network";
        public F_NewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BT_create_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pw + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command;

            String sql;

            sql = "insert into user values ('"+TB_uname.Text+"', '"+TB_password.Text+"', '"+CB_role.Text+ "');";

            command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
