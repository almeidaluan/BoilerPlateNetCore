using System.Data;

namespace BoilerplateNetCore.configuration.database
{
    public interface IConnectionFactory
    {
          IDbConnection Connection();
    }
}