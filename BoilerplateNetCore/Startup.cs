using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateNetCore.configuration.database;
using BoilerplateNetCore.configuration.database.mysql;
using BoilerplateNetCore.gateway;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BoilerplateNetCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["MySqlConnection:MySqlConnectionString"];
            
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));
            services.AddScoped<IHeroRepository,HeroRepositoryImpl>();
            services.AddSingleton<IConnectionFactory,MysqlDapper>();
            
            services.AddMvc();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
