using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class DBConnection
    {
        private string _connectionString;

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = _connectionString;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        protected SqlCommand GetCommand()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = GetConnection();

            return command;
        }

        public void Destroy()
        {
            if (GetConnection().State == System.Data.ConnectionState.Open)
            {
                GetConnection().Close();
            }

            //distry the connection
            GetConnection().Dispose();
        }
    }
}
