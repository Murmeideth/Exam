using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Demo
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "demo";
            string user = "root";
            string password = "0000";

            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
