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

            DB_Connect db = new DB_Connect();

            String sql;
            object[] o = new object[3];
            o[0] = TB_uname.Text;
            o[1] = TB_password.Text;
            o[2] = CB_role.Text;

            sql = "insert into user values (@val0,@val1,@val2);";
            db.query(sql, o);
            db.close();
            MessageBox.Show("User made successfully");
            


        }
    }
}
