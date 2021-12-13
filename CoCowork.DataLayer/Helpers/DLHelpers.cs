using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Helpers
{
    public static class DLHelpers
    {
        public const string connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";   

        public static SqlConnection Connection()
        {
            var connection = new SqlConnection(DLHelpers.connectionString);
            connection.Open();
            return connection;
        }
    }
}
