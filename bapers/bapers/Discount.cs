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
                dis = 1 - (dis / 10);

                price = (NoDis(selectedItems, customer) * dis);



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
