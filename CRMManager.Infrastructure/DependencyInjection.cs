using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Infrastructure.Persistence;
using CRMManager.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddDbContext<CRMManagerContext>(options => options.UseSqlServer("Server=localhost;Initial Catalog=CustomerManager;Persist Security Info=False;User ID=joel;Password=joel12345;MultipleActiveResultSets=False;Encrypt=false;TrustServerCertificate=False;"));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
