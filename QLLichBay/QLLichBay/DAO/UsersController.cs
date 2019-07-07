using QLLichBay.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLichBay.DAO
{
    public class UsersController
    {
        public Boolean CheckLogin(String user, String pass)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                String sql = "select * from dbo.Users where EMAIL = '" + user + "' and PASSWORD = '" + pass + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (SqlException e)
            {
                return false;
            }
        }
    }
}
