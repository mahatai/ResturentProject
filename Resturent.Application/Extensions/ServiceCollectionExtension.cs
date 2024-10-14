using Microsoft.Extensions.DependencyInjection;
using Resturent.Application.Resturents;
using Resturent.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddAplication(this IServiceCollection services)
        {
           services.AddScoped<IResturentService, ResturentService>();
        }
    }
}
