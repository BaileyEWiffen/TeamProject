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
        string user;
        Users u = new Users();
        MySqlDataReader dataReader;
        DB_Connect db = new DB_Connect();

        public F_NewUser(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BT_create_Click(object sender, EventArgs e)
        {
            if (user != "")
            {
                String sql = "UPDATE user set UserName = @val0, password = @val1, role = @val2 where UserName = @val3;";
                object[] o = { TB_uname.Text,TB_password.Text, CB_role.Text, u.UserName};
                db.query(sql, o);
                db.close();
                this.Close();
            }
            else
            {
                String sql;
                object[] o = new object[3];
                o[0] = TB_uname.Text;
                o[1] = TB_password.Text;
                o[2] = CB_role.Text;

                sql = "insert into user values (@val0,@val1,@val2);";
                db.query(sql, o);
                db.close();
                MessageBox.Show("User made successfully");
                this.Close();
            }


               
            


        }

        private void F_NewUser_Load(object sender, EventArgs e)
        {
            {
                if(user != "")
                {
                    string sql = "SELECT * from user where userName = @val0;";
                    object[] o = { user };
                    dataReader = db.query(sql, o);
                    while (dataReader.Read())
                    {
                        u.UserName = dataReader.GetValue(0).ToString();
                        u.password = dataReader.GetValue(1).ToString();
                        u.role = dataReader.GetValue(2).ToString();
                    }
                    db.close();
                    dataReader.Dispose();
                    TB_uname.Text = u.UserName;
                    TB_password.Text = u.password;
                    CB_role.Text = u.role;
                }
            }
        }
    }
}

public class Users
{
    public string UserName { get; set; }
    public string password { get; set; }
    public string role { get; set; }
  

}
