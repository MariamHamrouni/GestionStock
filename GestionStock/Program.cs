
using Microsoft.Extensions.DependencyInjection;
using System;
using GestionStock.Data;


namespace GestionStock
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            
            var services = new ServiceCollection();
            //Enregistrer le StockContext avec les service SQLite
            services.AddGestionStockDataService();

            services.ApplyMigartionsForGestionStockDataService();

            // Initialisation de la configuration de l'application
            ApplicationConfiguration.Initialize();

            // Construction du fournisseur de services qui g�re les instances des d�pendances
            ServiceProvider = services.BuildServiceProvider();

            // R�cup�ration de l'instance de la fen�tre principale via l'injection de d�pendances
           // var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(new Form1());
        }
    }
}