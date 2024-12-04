using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
namespace HelloWorld { 
public class Program
    {
        public static void Main()
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                string sqlCommand = "SELECT GETDATE()";
                DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
                Console.WriteLine(rightNow);
            }
        }
    }
}
