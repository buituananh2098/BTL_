using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLichBay.DAO
{
    class DBSQLServerUtils
    {
        public static SqlConnection
                GetDBConnection(string datasource, string database)
            {
                //
                // Data Source=DESKTOP-D5N4DEM\SQLEXPRESS;Initial Catalog=QLMayBay1;Integrated Security=True
                //
                string connString = @"Data Source=" + datasource + ";Initial Catalog="
                            + database + ";Integrated Security=True;";

                SqlConnection conn = new SqlConnection(connString);

                return conn;
            }
    }
}
