using QLLichBay.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLichBay.DAO.DB;

namespace QLLichBay.DAO
{
    public class AirportsController
    {
        public List<Airports> getAll()
        {
            List<Airports> sc = new List<Airports>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT *FROM Airports";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Airports obj = dr.Cast<Airports>();
                sc.Add(obj);
            }
            return sc;
        }
        public Airports getById(int id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT *FROM Airports WHERE ID = "+ id;
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Airports ap = dt.Rows[0].Cast<Airports>();
            return ap;
        }
    }
}
