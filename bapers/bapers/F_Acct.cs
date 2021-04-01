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
            CustSearch("");
            TaskSearch("");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
        
        private void BT_search_Click(object sender, EventArgs e)
        {
            



        }

        private void TB_search_TextChanged(object sender, EventArgs e)
        {
            CustSearch(TB_search.Text);
            

        }

        private void B_tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (B_addedTask.Items.Contains(B_tasks.SelectedItem))
            {
                BT_addRemove.Text = "Remove";
            }
            else
            {
                BT_addRemove.Text = "Add";
            }
        }

        private void CustSearch(string search) {
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

        private void TaskSearch(string search)
        {
            DB_Connect db = new DB_Connect();
            MySqlDataReader dataReader;
            B_tasks.Items.Clear();
            string sql = "SELECT * FROM task where (task_ID like @val0) OR (task_description like @val0);";
            object[] o = new object[1];
            o[0] = "%"+search + "%";

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

        private void TB_tasks_TextChanged(object sender, EventArgs e)
        {
            TaskSearch(TB_tasks.Text);
        }

        private void BT_addRemove_Click(object sender, EventArgs e)
        {
            if (B_addedTask.Items.Contains(B_tasks.SelectedItem))
            {
                B_addedTask.Items.Remove(B_tasks.SelectedItem);
                BT_addRemove.Text = "Add";
            }
            else
            {
                B_addedTask.Items.Add(B_tasks.SelectedItem);
                BT_addRemove.Text = "Remove";
            }
        }

        private void BT_createJob_Click(object sender, EventArgs e)
        {

            for(int i =0; i< Convert.ToInt32(TB_q.Text); i++)
            {
                if (B_contact.SelectedItem != null)
                {
                    DB_Connect db = new DB_Connect();
                    MySqlDataReader dataReader;
                    string CustNo = "";




                    string sql = "SELECT account_number FROM customer where contact_name = @val0;";
                    object[] o = new object[1];
                    o[0] = B_contact.SelectedItem.ToString();

                    dataReader = db.query(sql, o);

                    while (dataReader.Read())
                    {
                        CustNo = dataReader.GetValue(0).ToString();

                    }
                    dataReader.Dispose();
                    db.close();

                    sql = "SELECT MAX(job_number) from job;";
                    object[] job = new object[0];

                    dataReader = db.query(sql, job);
                    int jn = 0;
                    while (dataReader.Read())
                    {
                        jn = Convert.ToInt32(dataReader.GetValue(0)) + 1;

                    }
                    dataReader.Dispose();
                    db.close();



                    string sql2 = "INSERT INTO JOB values (@val0,@val1,@val2,@val3,@val4,@val5);";
                    object[] o2 = { jn, DateTime.Parse(TB_deadline.Text), TB_instr.Text, CustNo, "Pending", null };
                    dataReader = db.query(sql2, o2);
                    dataReader.Dispose();
                    db.close();



                    foreach (string s in B_addedTask.Items)
                    {
                        int id = Convert.ToInt32(s.Substring(0, 1));
                        string create = "INSERT INTO task_job values (@val0,@val1,@val2,@val3,@val4,@val5,@val6);";
                        object[] ob = { id, jn, null, null, null, 0, null };
                        dataReader = db.query(create, ob);
                        dataReader.Dispose();
                        db.close();

                    }
                    MessageBox.Show("Successfully created Job for " + B_contact.SelectedItem.ToString());


                }


            }


        }

        private void BT_newCust_Click(object sender, EventArgs e)
        {
            F_CustCreation fc = new F_CustCreation("");
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_CustCreation fc = new F_CustCreation(B_contact.SelectedItem.ToString());
            this.Hide();
            fc.ShowDialog();
            this.Show();

        }
    }
}
