using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bapers
{
    class Discount
    {
        MySqlDataReader dataReader;
        DB_Connect db = new DB_Connect();
        public float CalDiscount(object[] selectedItems, string customer)
        {
            string disType="";
            float price = 0;
            string sql = "select agreed_discount from customer where account_number =@val0;";
            object[] accNo = { customer };
            dataReader = db.query(sql, accNo);
            float dis=0;
            while (dataReader.Read())
            {
                disType = dataReader.GetValue(0).ToString();
            }
            dataReader.Dispose();
            db.close();
            


            if (disType == "")
            {

                price = NoDis(selectedItems, customer);
            }

            else if(disType =="fixed")
            {
                sql = "select FixedDiscount from customer where account_number =@val0;";
                dataReader = db.query(sql, accNo);

                while (dataReader.Read())
                {
                    dis = (float)dataReader.GetValue(0);
                }
                dataReader.Dispose();
                db.close();
                dis = 1 - (dis / 100);

                price = (NoDis(selectedItems, customer) * dis);



            }
            else if(disType == "variable")
            {
                List<string> tasks = new List<string>();
                foreach (object j in selectedItems)
                {
                    
                    string s = "SELECT Task_ID from task_job where Job_number = @val0;";
                    object[] o = { j };
                    dataReader =  db.query(s, o);
                    while (dataReader.Read())
                    {
                        tasks.Add(dataReader.GetValue(0).ToString());
                    }
                    dataReader.Dispose();
                    db.close();
                }

                foreach (string s in tasks)
                {
                    string c = "Select t.price, v.Discount from task t left join variable_discount v on v.Tasktask_ID = t.task_ID where t.task_ID = @val0; ";
                    object[] o = { s };
                    dataReader = db.query(c, o);
                    while (dataReader.Read())
                    {
                        int d = 0;
                        if(dataReader.GetValue(1) != null)
                        {
                            d = (int)dataReader.GetValue(1);
                        }
                        price += ((float)dataReader.GetValue(0) * (1 - (d / 100)));
                    }

                }
            }

            

            return price;
        }

        private float NoDis(object[] selectedItems, string customer)
        {
            float p = 0;
            



            object[] hold = new object[1];
            string sql = "select task.price from task_job inner join task on task.task_ID = task_job.Task_ID WHERE task_job.Job_number = @val0;";

            foreach (object o in selectedItems)
            {
                hold[0] = o;
                dataReader = db.query(sql, hold);
                while (dataReader.Read())
                {


                    p += (float)dataReader.GetValue(0);


                }
                dataReader.Dispose();
                db.close();



            }
            return p;

        }




    }
}
