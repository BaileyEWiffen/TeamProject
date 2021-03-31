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
        string[] user;


        public F_Proc(string u)
        {
            InitializeComponent();
            user = u.Split(',');
        }

        private void F_Proc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bapersDataSet1.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter2.Fill(this.bapersDataSet1.job);
            // TODO: This line of code loads data into the 'jobDeadlineStat.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter1.Fill(this.jobDeadlineStat.job);

            // TODO: This line of code loads data into the 'bapersDataSet.job' table. You can move, or remove it, as needed.
            //this.jobTableAdapter.Fill(this.bapersDataSet.job);

           

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
            LB_test.Text = d.Row["job_number"].ToString();

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
            string sql = "UPDATE task_job SET status =@val0 WHERE Task_ID = @val1 AND Job_number = @val2;";
            object[] o = new object[3];
            o[0] = TB_status.Text;
            o[1] = Ti;
            o[2] = Jn;
            //MessageBox.Show(TB_status.Text +" " +Ti.ToString() +" " +Jn.ToString());
            db.query(sql, o);
            
            db.close();
            if(TB_status.Text == "1")
            {
                sql = "UPDATE task_job SET Useremail =@val0 ,StartTime =@val1  WHERE Task_ID = @val2 AND Job_number = @val3;";
                object[] job = new object[4];
                job[0] = user[1].Trim();
                job[1] = FixedTime();
                job[2] = Ti;
                job[3] = Jn;
                db.query(sql, job);
                db.close();
            }
            if(TB_status.Text == "2")
            {
                string sTime ="";
                sql = "SELECT StartTime From task_job where Task_ID = @val0 and Job_number = @val1;";
                object[] time = { Ti, Jn };
                 
                MySqlDataReader reader = db.query(sql, time);
                
                while (reader.Read())
                {
                    sTime = reader.GetValue(0).ToString();
                }
                db.close();
                sql = "UPDATE task_job SET TimeTaken = @val0  WHERE Task_ID = @val1 AND Job_number = @val2;";
                object[] set = { timeTaken(FixedTime(), sTime),Ti,Jn };
                db.query(sql, set);
                db.close();

            }
            UpdataStat();


        }

        private void UpdataStat()
        {
            DataRowView d = (DataRowView)B_job.Items[B_job.SelectedIndex];
            DB_Connect db = new DB_Connect();
            String sql = "select Task_ID, status from task_job where Job_number =@val0;";
            object[] o = new object[1];
            o[0] = Convert.ToInt32(d.Row["job_number"]);
            Jn = Convert.ToInt32(d.Row["job_number"]);
            MySqlDataReader reader = db.query(sql, o);
            B_Task.Items.Clear();

            List<Job_task> j = new List<Job_task>();

            while (reader.Read())
            {
                Job_task jt = new Job_task();
                jt.job_number = (int)o[0];
                jt.task_id = (int)reader[0];
                jt.status = (int)reader[1];
                j.Add(jt);
                B_Task.Items.Add(jt.task_id.ToString() + " : " + jt.status.ToString());

            }
            db.close();
            reader.Dispose();

            int a = 0;
            int c = 0;
            int no = 0;
            foreach(Job_task jt in j)
            {
                if(jt.status ==1)
                {
                    a++;
                    
                }
                else if(jt.status == 2)
                {
                    c++;
                }
            }
            object[] stat = new object[2];
            stat[1] = o[0];
           
            if (c == j.Count)
            {
              
                stat[0] = "Complete";
            }
            else if (a>0)
            {
               
                stat[0] = "Active";
            }
            else
            {
              
                no = 1;
            }

            if(no == 0)
            {
                
                string s = "UPDATE job set Status = @val0 where job_number =@val1;";
                db.query(s, stat);
                db.close();
            }
            //this.jobTableAdapter2.Fill(this.bapersDataSet1.job);
            // TODO: This line of code loads data into the 'jobDeadlineStat.job' table. You can move, or remove it, as needed.
            //this.jobTableAdapter1.Fill(this.jobDeadlineStat.job);

        }

        private void jobBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void jobDeadlineStatBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private int timeTaken(string s1,string s2)
        {
            int t =0;
            string[] first = s1.Split(':');
            string[] second = s2.Split(':');

            int f = (Convert.ToInt32(first[0]) * 60) + Convert.ToInt32(first[1]);
            int s = (Convert.ToInt32(second[0]) * 60) + Convert.ToInt32(second[1]);

            t = f - s;

            return t;
        }

        private string FixedTime()
        {
            string t = DateTime.Now.ToString("h:mm:ss tt").Substring(DateTime.Now.ToString("h:mm:ss tt").Length - 2);

            if (t == "AM")
            {
                return DateTime.Now.ToString("h:mm:ss");
            }
            else
            {
                string[] f = DateTime.Now.ToString("h:mm:ss").Split(':');
                f[0] = Convert.ToString(Convert.ToInt32(f[0]) + 12);
                t = f[0] + ":" + f[1] + ":" + f[2];
            }

            return t;
        }
    }
}
