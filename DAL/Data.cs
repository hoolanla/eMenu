using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class Data
    {


        public DataTable Test()
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt;
                String sql;
                sql = "Select * From provinces ";
                Class.clsDB db = new Class.clsDB();
                dt = db.ExecuteDataTable(sql);
                db.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }



    }
}
