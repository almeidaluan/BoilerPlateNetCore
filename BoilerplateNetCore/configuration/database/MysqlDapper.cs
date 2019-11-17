using System.Data;
using System.Data.SqlClient;

namespace BoilerplateNetCore.configuration.database
{
    public class MysqlDapper : IConnectionFactory
    {
        public IDbConnection Connection()
        {
            return new SqlConnection("Database=HeroDB;Data Source=(localdb)\\MSSQLLocalDB;");
        }
    }
}