using System.Data;
using System.Data.SqlClient;

namespace CoCowork.DataLayer.Repositories
{
    public abstract class BaseRepository
    {
        private const string _сonnString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB;";

        protected IDbConnection ProvideConnection()
        {
            IDbConnection connection = new SqlConnection(_сonnString);
            return connection;
        }
    }
}
