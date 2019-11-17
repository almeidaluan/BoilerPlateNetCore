using BoilerplateNetCore.configuration.database.mysql;
using System.Linq;
using Dapper;
using BoilerplateNetCore.configuration.database;

namespace BoilerplateNetCore.gateway
{
    public class HeroRepositoryImpl : IHeroRepository
    {
        private readonly MysqlDapper contextDapper;

        public HeroRepositoryImpl(MysqlDapper contextDapper){
            this.contextDapper = contextDapper;
        }

        public void listHero(){
           contextDapper.Connection().Execute("");
        }
        
    }
}