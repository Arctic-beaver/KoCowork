using System.Data;
using System.Data.SqlClient;

namespace CoCowork.DataLayer.Repositories
{
    public abstract class BaseRepository
    {
        private const string _сonnString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB;";
        //private const string _сonnString = "Data Source=WIN-4PTG0MGAJ62\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected IDbConnection ProvideConnection()
        {
            IDbConnection connection = new SqlConnection(_сonnString);
            return connection;
        }
    }
}
