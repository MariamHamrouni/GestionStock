using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GestionStock.Data.Context;
using System.Linq;


namespace GestionStock
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGestionStockDataService(this IServiceCollection services)
        {
            services.AddDbContext<StockDbContext>(options =>
            {
                options.UseSqlite("Data Source=stock.db");

            }
              , ServiceLifetime.Transient
            );
            return services;
        }
            
  

    public static void ApplyMigartionsForGestionStockDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<StockDbContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
            } 
        }

    }
}

