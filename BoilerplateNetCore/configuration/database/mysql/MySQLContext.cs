

using BoilerplateNetCore.domain.model;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateNetCore.configuration.database.mysql
{
public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
}
}