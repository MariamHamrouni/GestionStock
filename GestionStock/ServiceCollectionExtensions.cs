using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GestionStock.Data.Context;


namespace GestionStock
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterForms(this IServiceCollection services)
        {
            services.AddTransient<Form1>();
            services.AddTransient<DashboardForm>();
            services.AddTransient<MouvementStockForm>();
            services.AddTransient<ProduitForm>();
            
        }

    }
}

