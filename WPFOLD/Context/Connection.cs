using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFOLD.Context
{
    class Connection
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=localhost;user id=root;database=db_mcc;password=b0o7c@mp");
        }
    }
}
