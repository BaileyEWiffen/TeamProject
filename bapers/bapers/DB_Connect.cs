using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bapers
{
    class DB_Connect
    {
        //private string connectionString = "SERVER=" + "localhost" + ";" + "DATABASE=" + "bapers" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "network" + ";";
        private MySqlConnection connection = new MySqlConnection("SERVER=" + "localhost" + ";" + "DATABASE=" + "bapers" + ";" + "UID=" + "root" + ";" + "PASSWORD=" + "network" + ";");

        public void close()
        {
            connection.Close();
        }
      


        public MySqlDataReader query(string sql, object[] a)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand(sql, connection);
            

            for(int i =0; i < a.Length; i++)
            {

                command.Parameters.AddWithValue("@val"+Convert.ToString(i), a[i]);
            }
            command.Prepare();

            MySqlDataReader dataReader ;
            dataReader = command.ExecuteReader();
            
            return dataReader;

        }

    
    
    }

}
