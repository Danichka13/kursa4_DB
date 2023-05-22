using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KursWork
{
    internal class DB
    {
        static string connectionString = @"Data Source=DANIIL\MSSQLSERVER_KURS;Initial Catalog=kurswork;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DANIIL\MSSQLSERVER_KURS;Initial Catalog=kurswork;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }
        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        public string getConnectionString() {
            return connectionString;
        }
    }
}

