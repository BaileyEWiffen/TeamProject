using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bapers
{
    public partial class F_Proc : Form
    {
        int Jn;
        int Ti;
        public F_Proc()
        {
            InitializeComponent();
        }

        private void F_Proc_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'bapersDataSet.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.bapersDataSet.job);

        }

        private void BT_test_Click(object sender, EventArgs e)
        {
            
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView d = (DataRowView)B_job.Items[B_job.SelectedIndex];
            LB_test.Text = d.Row["job number"].ToString();

            UpdataStat();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void B_Task_SelectedIndexChanged(object sender, EventArgs e)
        {
            String stat = B_Task.SelectedItem.ToString();

            string s = stat.Substring(Math.Max(0, stat.Length - 1));

            Ti = Convert.ToInt32(stat.Substring(0,1));

            TB_status.Text = s;

        }

        private void BT_statUpdata_Click(object sender, EventArgs e)
        {
            DB_Connect db = new DB_Connect();
            string sql = "UPDATE task_job SET status =@val0 WHERE Task_ID = @val1 AND Job_number = @val2";
            object[] o = new object[3];
            o[0] = TB_status.Text;
            o[1] = Ti;
            o[2] = Jn;
            //MessageBox.Show(TB_status.Text +" " +Ti.ToString() +" " +Jn.ToString());
            MySqlDataReader reader = db.query(sql, o);
            reader.Dispose();
            UpdataStat();


        }

        private void UpdataStat()
        {
            DataRowView d = (DataRowView)B_job.Items[B_job.SelectedIndex];
            DB_Connect db = new DB_Connect();
            String sql = "select Task_ID, status from task_job where Job_number =@val0";
            object[] o = new object[1];
            o[0] = Convert.ToInt32(d.Row["job number"]);
            Jn = Convert.ToInt32(d.Row["job number"]);
            MySqlDataReader reader = db.query(sql, o);
            B_Task.Items.Clear();



            while (reader.Read())
            {
                Job_task jt = new Job_task();

                jt.task_id = (int)reader[0];
                jt.status = (int)reader[1];

                B_Task.Items.Add(jt.task_id.ToString() + " : " + jt.status.ToString());

            }
            db.close();
            reader.Dispose();
        }
    }
}
