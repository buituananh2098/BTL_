using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLichBay.DAO
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-D5N4DEM\SQLEXPRESS";
            string database = "MANAGER_FLIGHT";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}