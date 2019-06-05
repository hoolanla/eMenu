using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL.Class
{

 
 


    public class clsDB
    {
        private String strConnString;
        private NpgsqlConnection objConn;
        private NpgsqlCommand objCmd;
      

        public clsDB()
        {
            strConnString = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }

        public void Close()
        {
            objConn.Close();
            objConn = null;
        }

        public DataTable ExecuteDataTable(String strSQL)
        {
            NpgsqlDataAdapter dtAdapter;
            DataTable dt = new DataTable();
            objConn = new NpgsqlConnection();
            objConn.ConnectionString = strConnString;
            objConn.Open();

            dtAdapter = new NpgsqlDataAdapter(strSQL, objConn);
            dtAdapter.Fill(dt);
            return dt; //*** Return DataTable ***//
        }

    }
}
