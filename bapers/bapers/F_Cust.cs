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
        MySqlDataReader dataReader;
        DB_Connect db = new DB_Connect();
        bool b = false;
        public F_Cust()
        {
            InitializeComponent();
            TaskSearch("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CustSearch(TB_search.Text);
        }
        private void CustSearch(string search)
        {
            

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
        private void TaskSearch(string search)
        {
           
            B_tasks.Items.Clear();
            string sql = "SELECT * FROM task where (task_ID like @val0) OR (task_description like @val0);";
            object[] o = new object[1];
            o[0] = "%" + search + "%";

            dataReader = db.query(sql, o);

            while (dataReader.Read())
            {
                string s = dataReader.GetValue(0).ToString();

                s += " " + dataReader.GetValue(1).ToString();

                B_tasks.Items.Add(s);


            }
            dataReader.Dispose();
            db.close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CB_dType.Text == "Fixed")
            {

            }
        }

        private void B_contact_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string sql = "SELECT valued_customer from customer where contact_name = @val0;";
            object[] o = { B_contact.SelectedItem.ToString() };
            dataReader = db.query(sql, o);
            Boolean temp =false;
            while (dataReader.Read())
            {
                temp = Convert.ToBoolean(dataReader.GetValue(0));
                
            }
            dataReader.Dispose();
            db.close();
            b = true;
            if (temp)
            {
                
                C_value.Checked = true;
            }
            if (!temp)
            {
                C_value.Checked = false;
            }
            b = false;
        }

        private void C_value_CheckedChanged(object sender, EventArgs e)
        {
            if (!b)
            {
                string sql = "UPDATE customer set valued_customer = @val0 where contact_name= @val1;";
                object[] o = new object[2];
                o[1] = B_contact.SelectedItem.ToString();
                if (C_value.Checked)
                {
                    o[0] = 1;
                }
                else if (!C_value.Checked)
                {
                    o[0] = 0;
                }
                db.query(sql, o);
                db.close();

            }
            
        }

        private void BT_enter_Click(object sender, EventArgs e)
        {

            string s = "update customer set agreed_discount = @val0 where contact_name =  @val1;";
            object[] o1 = {CB_dType.Text, B_contact.SelectedItem.ToString() };
            db.query(s, o1);
            db.close();

            if (CB_dType.Text == "Fixed")
            {
                string sql = "update customer set agreed_discount = 'Fixed', FixedDiscount = @val0 where contact_name =  @val1;";
                object[] o = { TB_discount.Text, B_contact.SelectedItem.ToString() };
                db.query(sql, o);
                db.close();
            }
            else if (CB_dType.Text == "Variable")
            {
                string sql = "SELECT c.account_number FROM variable_discount vd" +
                    " inner join customer c on vd.Customeraccount_number = c.account_number" +
                    " where c.contact_name = @val0 and Tasktask_ID = @val1; ";
                object[] n = { B_contact.SelectedItem.ToString(), B_tasks.SelectedItem.ToString().Substring(0, 1) };
                dataReader = db.query(sql, n);
                string p = "No";
                while (dataReader.Read())
                {
                    p = dataReader.GetValue(0).ToString();
                }
                db.close();
                dataReader.Dispose();

              

                if (p != "No")
                {
                    
                    sql = "UPDATE variable_discount set Discount =@val1 where Customeraccount_number = @val2 AND Tasktask_ID = @val0;";
                    object[] updateV = { B_tasks.SelectedItem.ToString().Substring(0, 1), TB_discount.Text,p };
                    db.query(sql, updateV);
                    db.close();
                }
                else if(p == "No")
                {
                    sql = "INSERT INTO variable_discount values(@val0,@val1,(SELECT account_number from customer where contact_name = @val2) );";
                    object[] updateV = { B_tasks.SelectedItem.ToString().Substring(0, 1), TB_discount.Text, B_contact.SelectedItem.ToString() };
                    db.query(sql, updateV);
                    db.close();
                }

            }
            else if (CB_dType.Text == "Flexible")
            {
                string sql = "SELECT c.account_number FROM flexable_discount fd" +
                    " inner join customer c on fd.Customeraccount_number = c.account_number" +
                    " where c.contact_name = @val0 AND fd.upper = @val1 AND fd.lower = @val2; ";
                object[] n = { B_contact.SelectedItem.ToString(), TB_upper.Text, TB_lower.Text };
                dataReader = db.query(sql, n);
                string p = "No";
                while (dataReader.Read())
                {
                    p = dataReader.GetValue(0).ToString();
                }
                db.close();
                dataReader.Dispose();

                if (p != "No")
                {
                    sql = "DELETE from flexable_discount WHERE Customeraccount_number = @val0;";
                    object[] df = {p};
                    db.query(sql, df);
                    db.close();

                }
                
                    sql = "INSERT INTO flexable_discount values(@val0,@val1,@val2,(SELECT account_number from customer where contact_name = @val3) );";
                    object[] updateV = { TB_upper.Text,TB_lower.Text, TB_discount.Text, B_contact.SelectedItem.ToString() };
                    db.query(sql, updateV);
                    db.close();

                

            }

        }
    }
}
