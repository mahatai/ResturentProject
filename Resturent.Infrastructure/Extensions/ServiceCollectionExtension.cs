using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Resturent.Infrastructure.Persistance;
using Resturent.Infrastructure.Repository;
using Resturent.Infrastructure.Seaders;
using Resturent.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ResturentDbConnection");
            services.AddDbContext<ResturentDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IResturentSeader, ResturentSeader>();
            services.AddScoped<IResturentsRepository, ResturentRepository>();
        }
    }
}
