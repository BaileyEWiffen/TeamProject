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
    public partial class F_Rept : Form
    {
        MySqlDataReader dataReader;
        DB_Connect db = new DB_Connect();
        public F_Rept()
        {
            InitializeComponent();
            CustSearch("");
        }

        private void BT_gen_Click(object sender, EventArgs e)
        {
            B_gen.Items.Clear();
            if (CB_rept.Text == "Individual report")
            {
               
                B_gen.Items.Add("Job | Price | Task | Department | StartTime | TimeTaken | Completed By");

                string sql = "SELECT j.job_number AS job, t.price, t.task_ID AS Task, T.location AS Department,Tj.startTime, " +
                    "Tj.TimeTaken, u.UserName AS Completed_by FROM job j inner join Customer c" +
                    " on c.account_number = j.customerAccount_number" +
                    " inner join Task_job Tj" +
                    " ON Tj.Job_Number = j.Job_Number" +
                    " inner join task t" +
                    " on t.Task_ID = Tj.Task_ID" +
                    " INNER JOIN User u" +
                    " ON u.UserName = Tj.Useremail" +
                    " WHERE c.customer_name = @val0 AND Tj.TimeTaken is not null; ";

                object[] o = { B_contact.SelectedItem.ToString() };
                dataReader = db.query(sql, o);
                while (dataReader.Read())
                {

                    string item = dataReader.GetValue(0).ToString() + " | " +
                        dataReader.GetValue(1).ToString() + " | " +
                        dataReader.GetValue(2).ToString() + " | " +
                        dataReader.GetValue(3).ToString() + " | " +
                        dataReader.GetValue(4).ToString() + " | " +
                        dataReader.GetValue(5).ToString() + " | " +
                        dataReader.GetValue(6).ToString();
                    B_gen.Items.Add(item);
                }
                db.close();
                dataReader.Dispose();

            }
            else if(CB_rept.Text == "performance report")
            {
                B_gen.Items.Add("UserName | Task | Department | Date | StartTime | TimeTaken");
                string sql = "SELECT u.UserName , t.task_ID, T.Location AS Department, Tj.FinishDate AS" +
                    " Date, Tj.startTime, Tj.TimeTaken" +
                    " FROM Task_Job Tj" +
                    " INNER JOIN Task t" +
                    " ON Tj.Task_ID = t.Task_ID" +
                    " INNER JOIN User u" +
                    " ON Tj.Useremail = u.UserName" +
                    " INNER JOIN Job j" +
                    " ON Tj.Job_number = J.job_number" +
                    " WHERE Tj.FinishDate between @val0 and @val1; ";
                object[] o = { TB_gen.Text, TB_date.Text };

                dataReader = db.query(sql, o);
                while (dataReader.Read())
                {

                    string item = dataReader.GetValue(0).ToString() + " | " +
                        dataReader.GetValue(1).ToString() + " | " +
                        dataReader.GetValue(2).ToString() + " | " +
                        dataReader.GetValue(3).ToString().Substring(0, 10) + " | " +
                        dataReader.GetValue(4).ToString() + " | " +
                        dataReader.GetValue(5).ToString();
                        
                    B_gen.Items.Add(item);
                }
                db.close();
                dataReader.Dispose();
                
            }
            else if (CB_rept.Text == "summary report")
            {
                

                string sql = "SELECT sum(tj.TimeTaken), tj.finishDate from " +
                    " task_job tj" +
                    " join task t on tj.Task_ID = t.task_ID" +
                    " where(t.location = @val0) AND Tj.FinishDate between @val1 and @val2" +
                    " group by tj.finishDate" +
                    " order by tj.finishDate; ";
                object[] o = {"Copy Room", TB_gen.Text, TB_date.Text};
                
                List < Srep >  r = new List<Srep>();

                dataReader = db.query(sql, o);
                while (dataReader.Read())
                {
                    int collection;

                    if (dataReader.GetValue(0) == DBNull.Value)
                    {
                        collection = 0;
                    }
                    else
                    {
                        collection = Convert.ToInt32(dataReader.GetValue(0));
                    }

                    Srep p = new Srep();
                    p.Date = dataReader.GetValue(1).ToString();
                    p.Copy = collection;
                    r.Add(p);

                }
                db.close();
                dataReader.Dispose();

                o[0] = "Development area";
                dataReader = db.query(sql, o);
                while (dataReader.Read())
                {
                    int collection;

                    if(dataReader.GetValue(0) == DBNull.Value)
                    {
                        collection = 0;
                    }
                    else
                    {
                        collection = Convert.ToInt32(dataReader.GetValue(0));
                    }


                    int temp = 0;
                    foreach(Srep ss in r)
                    {
                        if (ss.Date== dataReader.GetValue(1).ToString())
                        {
                            ss.Dev = collection;
                            temp = 1;
                        }
                        
                    }

                    if(temp == 0)
                    {
                        Srep p = new Srep();
                        p.Date = dataReader.GetValue(1).ToString();
                        p.Dev = collection;
                        r.Add(p);

                    }

                    

                }
                db.close();
                dataReader.Dispose();

                o[0] = "Finishing Room";
                dataReader = db.query(sql, o);
                while (dataReader.Read())
                {

                    int collection;

                    if (dataReader.GetValue(0) == DBNull.Value)
                    {
                        collection = 0;
                    }
                    else
                    {
                        collection = Convert.ToInt32(dataReader.GetValue(0));
                    }

                    int temp = 0;
                    foreach (Srep ss in r)
                    {
                        if (ss.Date == dataReader.GetValue(1).ToString())
                        {
                            ss.Fin = collection;
                            temp = 1;
                        }

                    }

                    if (temp == 0)
                    {
                        Srep p = new Srep();
                        p.Date = dataReader.GetValue(1).ToString();
                        p.Fin = collection;
                        r.Add(p);

                    }



                }
                db.close();
                dataReader.Dispose();


                o[0] = "Packing Departments";
                dataReader = db.query(sql, o);
                while (dataReader.Read())
                {
                    int collection;

                    if (dataReader.GetValue(0) == DBNull.Value)
                    {
                        collection = 0;
                    }
                    else
                    {
                        collection = Convert.ToInt32(dataReader.GetValue(0));
                    }

                    int temp = 0;
                    foreach (Srep ss in r)
                    {
                        if (ss.Date == dataReader.GetValue(1).ToString())
                        {
                            ss.Pack = collection;
                            temp = 1;
                        }

                    }

                    if (temp == 0)
                    {
                        Srep p = new Srep();
                        p.Date = dataReader.GetValue(1).ToString();
                        p.Pack = collection;
                        r.Add(p);

                    }



                }
                db.close();
                dataReader.Dispose();

                foreach(Srep ss in r)
                {
                    B_gen.Items.Add(ss.Date.Substring(0, 10) + " | "+ ss.Copy.ToString()+" | " + ss.Dev.ToString() + " | " + ss.Fin.ToString() + " | " + ss.Pack.ToString());
                }



            }
            else
            {
                //B_gen.Items.Add(DayDiff(TB_gen.Text, TB_date.Text));
            }
            
        }
        private int DayDiff(string s1, string s2)
        {
            int i =0;
            string[] date1 =s1.Split('-');
            string[] date2 = s2.Split('-');
            int d1 =(Convert.ToInt32(date1[0])*365)+ (Convert.ToInt32(date1[1]) * 31)+ Convert.ToInt32(date1[2]);
            int d2 = (Convert.ToInt32(date2[0]) *365)+(Convert.ToInt32(date2[1]) * 31) + Convert.ToInt32(date2[2]);
            i = d2 - d1;
            return i+1;
        }
        private Boolean search(string[,] r, string s)
        {
            foreach(string ss in r)
            {
                if(ss == s)
                {
                    return true;

                }
            }

            return false;
        }
        private int col(string[,] ss, int i)
        {
            int j = 0;
            return j;
        }

        private void CustSearch(string search)
        {

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

    }
}
public class Srep
{
    public string Date { get; set; }
    public int Copy { get; set; } =0;
    public int Dev { get; set; } = 0;
    public int Fin { get; set; } = 0;
    public int Pack { get; set; } = 0;

}
