using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddInfraService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ProgrammersDB");

            services.AddDbContext<ApplicationDataContext>(option => option.UseSqlServer(connectionString));

            return services;
        }
    }
}
