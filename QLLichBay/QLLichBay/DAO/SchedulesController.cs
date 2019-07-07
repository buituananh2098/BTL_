using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using QLLichBay.DAO.DB;
using QLLichBay.Model;

namespace QLLichBay.DAO
{
    public class SchedulesController
    {
        public List<Schedules> getAll()
        {
            List<Schedules> sc = new List<Schedules>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT *FROM SCHEDULES";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Schedules obj = dr.Cast<Schedules>();
                obj.TIME_.ToString ("0:HH:mm:ss tt");
                obj.BUSINESS_PRICE  = obj.ECONOMY_PRICE + obj.ECONOMY_PRICE * 30 / 100;
                obj.FIRST_CLASS_PRICE = obj.ECONOMY_PRICE + obj.ECONOMY_PRICE * 35 / 100;
                sc.Add(obj);
            }
            return sc;
        }
    }
}
