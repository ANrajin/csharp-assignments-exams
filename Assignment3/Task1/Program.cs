using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.\\SQLEXPRESS;Database=Assignment3;User Id=csharpb8;Password=123456;";

            ExecuteQuery query = new ExecuteQuery(connectionString);

            var sql = "SELECT * FROM Products";

            query.Select(sql);
        }
    }
}
