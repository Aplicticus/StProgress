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

        public void OpenConnection()
        {
            sqlConn.Open();
        }

        public void CloseConnection()
        {
            sqlConn.Close();
        }

        public DataSet GetDataset(string sqlQuery)
        {
            DataSet DS = new DataSet();
            sqlDA = new SqlDataAdapter(sqlQuery, sqlConn);
            sqlDA.Fill(DS);
            return DS;
        }
    }
}
