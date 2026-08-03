using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Data;
using Persistence.Repositories;

namespace Persistence
{
    public static class Extension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            IConfiguration configuration;
            using (ServiceProvider provider = services.BuildServiceProvider())
                configuration = ServiceProviderServiceExtensions.GetService<IConfiguration>(provider);

                services.AddDbContext<Data.ApplicationDbContext>(option => option.UseSqlServer(configuration["sql:cx"]));
            /* Direccion de sql local: "Server=localhost;Database=InvoiceDB;User Id=sa;Password=YourStrong!Passw0rd;" */ 
            services.AddTransient<IInvoices, InvoicesRepositories>();
            return services;
        }
    }
}
