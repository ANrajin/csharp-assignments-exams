using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Task1
{
    public class ExecuteQuery:DBConnection
    {
        public ExecuteQuery(string ConnectionString):base(ConnectionString)
        {
        }

        public void Select(string query)
        {
            using SqlCommand command = GetCommand();
            command.CommandText = query;

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string status = (bool)reader["isAvailable"] ? "Available" : "Not Available";

                Console.WriteLine($"Product: {reader["Title"]}, Price: {reader["Price"]}, Status: {status}, Stock: {reader["AvailableQuantity"]}, CreatedOn: {reader["CreatedOn"]}");
            }

            reader.Close();

            Destroy();
        }
    }
}
