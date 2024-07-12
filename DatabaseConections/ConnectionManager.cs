using DatabaseConections;
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace DatabaseConnections
{
    public class ConnectionManager
    {
        private string connectionString;
        private SqlConnection dataConnection;

        public SqlConnection DataConnection { get => dataConnection; set => dataConnection = value; }

        public ConnectionManager()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            DataConnection = new SqlConnection(connectionString);
        }
    }

}
