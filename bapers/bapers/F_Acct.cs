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
    public partial class F_Acct : Form
    {

        public F_Acct()
        {
            InitializeComponent();
        }

        private void F_Acct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactName2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.contactName2.customer);
           


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
        
        private void BT_search_Click(object sender, EventArgs e)
        {
            DB_Connect db = new DB_Connect();

            B_contact.Items.Clear();

            string sql = "SELECT contact_name FROM customer where contact_name like @val0;";
            object[] o = new object[1];
            o[0] = TB_search.Text +"%";

            MySqlDataReader dataReader = db.query(sql, o);


           
           
           

            while (dataReader.Read()) {
                int i = 0;
                
                B_contact.Items.Add(Convert.ToString(dataReader.GetValue(i)));
                i++;
                
            }



        }
    }
}
