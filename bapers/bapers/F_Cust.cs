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
    public partial class F_Cust : Form
    {
        public F_Cust()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CustSearch(TB_search.Text);
        }
        private void CustSearch(string search)
        {
            DB_Connect db = new DB_Connect();
            MySqlDataReader dataReader;

            B_contact.Items.Clear();

            string sql = "SELECT contact_name FROM customer where contact_name like @val0;";
            object[] o = new object[1];
            o[0] = search + "%";

            dataReader = db.query(sql, o);

            while (dataReader.Read())
            {


                B_contact.Items.Add(Convert.ToString(dataReader.GetValue(0)));


            }
            dataReader.Dispose();
            db.close();
        }
    }
}
