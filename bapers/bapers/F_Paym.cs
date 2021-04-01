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
    public partial class F_Paym : Form
    {
        string accNo;
        double p =0;
        public F_Paym()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CustSearch(TB_contact.Text);
        }

        private void CustSearch(string search)
        {
            DB_Connect db = new DB_Connect();
            MySqlDataReader dataReader;

            B_contact.Items.Clear();

            string sql = "SELECT customer_name FROM customer where customer_name like @val0;";
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

        private void F_Paym_Load(object sender, EventArgs e)
        {
            CustSearch("");
        }

        private void B_contact_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB_Connect db = new DB_Connect();
            MySqlDataReader dataReader;

            B_jobs.Items.Clear();

            string sql = "select job.job_number from job inner join customer on job.Customeraccount_number=customer.account_number WHERE customer.customer_name = @val0 AND job.status = 'Complete';";
            object[] o = new object[1];
            o[0] = B_contact.SelectedItem.ToString();

            dataReader = db.query(sql, o);

            while (dataReader.Read())
            {


                B_jobs.Items.Add(Convert.ToString(dataReader.GetValue(0)));


            }
            dataReader.Dispose();
            db.close();


        }

        private void B_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB_Connect db = new DB_Connect();
            MySqlDataReader dataReader;
            object[] o = new object[1];
            string sql = "SELECT account_number from customer where contact_name = @val0;";
            o[0] = B_contact.SelectedItem.ToString();
            dataReader = db.query(sql, o);
            
            while (dataReader.Read())
            {
                accNo = dataReader.GetValue(0).ToString();
            }
            dataReader.Dispose();
            db.close();

            Discount d = new Discount();
            LB_total.Text = "Total:";
            

            object[] jobs = new object[B_jobs.SelectedItems.Count];

            for (int i = 0; i < B_jobs.SelectedItems.Count; i++)
            {
                jobs[i] = B_jobs.SelectedItems[i];
            }

            p = d.CalDiscount(jobs, accNo);
            LB_total.Text += " " + p.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BT_pay_Click(object sender, EventArgs e)
        {
            string l4;
            string ct;
            string pt;
            string ed;
            if(TB_cardNo.Text != "")
            {
                l4 = TB_cardNo.Text.Substring(TB_cardNo.Text.Length - 4);
            }
            else
            {
                
               l4 = null;
            }

            if (TB_cardType.Text != "")
            {
                ct = TB_cardType.Text;
            }
            else
            {

                ct = null;
            }

            if (TB_payType.Text != "")
            {
                pt = TB_payType.Text;
            }

            else
            {

                pt = null;
            }

            if ( TB_expiryDate.Text != "")
            {
                ed = TB_expiryDate.Text;
            }

            else
            {

                ed = null;
            }
            object[] ma = { };
            DB_Connect db = new DB_Connect();
            MySqlDataReader dataReader;
            string max = "Select MAX(payment_id) from payment;";
             dataReader = db.query(max, ma);
            int pk = 0;
            while (dataReader.Read())
            {
                pk = ((int)dataReader.GetValue(0)+1);
            }
            db.close();

            object[] o = {pk,p, pt, ct,l4, accNo, ed};
            string sql = "insert into payment values(@val0,@val1,@val2,@val3,@val4,@val5,@val6);";
           //MessageBox.Show(p.ToString()+ pt+ ct+ l4+ accNo+ ed);
           db.query(sql, o);
            db.close();

            foreach(object j in B_jobs.SelectedItems)
            {
               
                
                object[] job = { j };
                string s = "UPDATE job set Status = 'Payed' where job_number = @val0;";
                db.query(s, job);
                db.close();
            }


        }
    }
}
