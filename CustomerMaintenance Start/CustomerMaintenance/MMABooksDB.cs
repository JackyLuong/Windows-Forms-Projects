using System;
using System.Collections.Generic;
using System.Data.SqlClient; // ADO.NET produver for SQL Server
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=MMABooks;Integrated Security=True";
            return new SqlConnection(connectionString);
        }


    }
}
