using BoilerplateNetCore.configuration.database.mysql;
using BoilerplateNetCore.configuration.database;
using System.Collections.Generic;
using BoilerplateNetCore.domain.model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateNetCore.gateway
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        //private readonly MysqlDapper contextDapper;

        private readonly MySQLContext contextMysql;

        public PersonRepositoryImpl(MySQLContext contextMysql){
            //this.contextDapper = contextDapper;
            this.contextMysql = contextMysql;
        }

        // public void listHeroDapper(){
        //    contextDapper.Connection().Query<Person>("SELECT * FROM livraria.PERSONS;");
        // }

        public List<Person> listPerson(){
            return contextMysql.Persons.FromSql("SELECT * FROM Persons;").ToList();
        }
    }
}