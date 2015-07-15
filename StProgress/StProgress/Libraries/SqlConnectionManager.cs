using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StProgress.SQL
{
    class SqlConnectionManager
    {

        private string sqlConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Resources\Database\StProgressDB.mdf;Integrated Security=True";

        private SqlConnection sqlConn = null;
        private SqlDataAdapter sqlDA = null;
        public SqlConnectionManager()
        {
            sqlConn = new SqlConnection(sqlConnectionString);            
        }

        public DataSet GetDataset(string sqlQuery)
        {
            DataSet DS = new DataSet();
            sqlDA = new SqlDataAdapter(sqlQuery, sqlConn);
            sqlDA.Fill(DS);
            return DS;            
        }

        public DataTable GetDataTable(string sqlQuery)
        {
            DataTable DT = new DataTable();
            sqlDA = new SqlDataAdapter(sqlQuery, sqlConn);
            sqlDA.Fill(DT);
            return DT;
        }

        public void WriteQuery(string sqlQuery)
        {

        }
        public void ReadQuery(string sqlQuery)
        {

        }
    }
}
