using System.Data;
using System.Data.SqlClient;

namespace CoCowork.DataLayer.Repositories
{
    public abstract class BaseRepository
    {
        private const string _сonnString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB;"; //"Server=(local);Integrated Security=true;Database=CoCowork.DB;";

        protected IDbConnection ProvideConnection() => new SqlConnection(_сonnString);
    }
}
