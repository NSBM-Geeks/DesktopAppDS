using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSystem
{
    class DBClass
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database= coopdb");

        //Open connection
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }



    }
}
