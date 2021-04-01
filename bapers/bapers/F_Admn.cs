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
    public partial class F_Admn : Form
    {
        DB_Connect db = new DB_Connect();
        MySqlDataReader dataReader;
        Task t = new Task();
        public F_Admn()
        {
            InitializeComponent();
            TaskSearch("");
            CustSearch("");
        }

        private void BT_newU_Click(object sender, EventArgs e)
        {
            F_NewUser fu = new F_NewUser("");
            this.Hide();
            fu.ShowDialog();
            this.Show();
        }

        private void TaskSearch(string search)
        {
           
            B_Tasks.Items.Clear();
            string sql = "SELECT * FROM task where (task_ID like @val0) OR (task_description like @val0);";
            object[] o = new object[1];
            o[0] = "%" + search + "%";

            dataReader = db.query(sql, o);

            while (dataReader.Read())
            {
                string s = dataReader.GetValue(0).ToString();

                s += " " + dataReader.GetValue(1).ToString();

                B_Tasks.Items.Add(s);


            }
            dataReader.Dispose();
            db.close();
        }

        private void CustSearch(string search)
        {
            
            B_user.Items.Clear();

            string sql = "SELECT UserName FROM user where UserName like @val0;";
            object[] o = new object[1];
            o[0] = search + "%";

            dataReader = db.query(sql, o);

            while (dataReader.Read())
            {


                B_user.Items.Add(Convert.ToString(dataReader.GetValue(0)));


            }
            dataReader.Dispose();
            db.close();
        }

        private void TB_task_TextChanged(object sender, EventArgs e)
        {
            TaskSearch(TB_task.Text);

        }

        private void TB_user_TextChanged(object sender, EventArgs e)
        {
            CustSearch(TB_user.Text);
        }

        private void B_Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * from task where task_ID =@val0;";
            object[] o = { B_Tasks.SelectedItem.ToString().Substring(0, 1) };
            dataReader = db.query(sql, o);
            while(dataReader.Read())
            {
                t.ID = Convert.ToInt32(dataReader.GetValue(0));
                t.taskD = dataReader.GetValue(1).ToString();
                t.loc = dataReader.GetValue(2).ToString();
                t.price = dataReader.GetValue(3).ToString();
                t.dur = dataReader.GetValue(4).ToString();
            }
            db.close();
            dataReader.Dispose();
            TB_des.Text = t.taskD;
            TB_loc.Text = t.loc;
            TB_price.Text = t.price;
            TB_dur.Text = t.dur;


        }

        public class Task
        {
            public int ID { get; set; }
            public string taskD{ get; set; }
            public string loc { get; set; }
            public string price { get; set; }
            public string dur { get; set; }
        }

        private void BT_updateT_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE task set task_description = @val0, location = @val1, price =@val2, duration = @val3 where task_ID = @val4;";
            object[] o = { TB_des.Text, TB_loc.Text, TB_price.Text, TB_dur.Text, t.ID };
            db.query(sql, o);
            db.close();
            TaskSearch("");
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            object[] ma = new object[0];
            string max = "Select MAX(task_id) from task;";
            dataReader = db.query(max, ma);
            int pk = 0;
            while (dataReader.Read())
            {
                pk = ((int)dataReader.GetValue(0) + 1);
            }
            db.close();


            string sql = "insert into task values(@val4,@val0, @val1, @val2, @val3);";
            object[] o = { TB_des.Text, TB_loc.Text, TB_price.Text, TB_dur.Text, pk };
            db.query(sql, o);
            db.close();
            TaskSearch("");

        }

        private void BT_delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from task where task_id = @val0;";
            object[] o = { t.ID };
            db.query(sql, o);
            db.close();
            TaskSearch("");
        }

        private void BT_userU_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sql = "BACKUP DATABASE bapers TO DISK = C:'\'Users'\'Bailey'\'Desktop'\'TeamProjectGit'\'TeamProject\testDB.bak;";
            //object[] o = { };
           // db.query(sql, o);
           //s db.close();
        }
    }
}
