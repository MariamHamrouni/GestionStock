using GestionStock.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace GestionStock.Data.Context
{
    public class StockDbContext : DbContext
    {
        //constructuer utilisé par EF core core tools
        public StockDbContext()
        {

        }
        // Constructeur avec DbContextOptions utilisé par l'application
        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
        {

        }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<MouvementStock> MouvementsStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
                options.UseSqlite("Data Source=stock.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produit>()
                .HasOne(p=>p.Categorie)
                .WithMany(c=>c.Produits)
                .HasForeignKey(p=>p.CategorieId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Categories>()
                .Property(c => c.Nom)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<MouvementStock>()
                     .HasOne(ms => ms.Produit)
                     .WithMany(p => p.MouvementsStock)
                     .HasForeignKey(ms => ms.ProduitId);
            modelBuilder.Entity<MouvementStock>()
                .Property(ms => ms.Quantite)
                .IsRequired();
            modelBuilder.Entity<Produit>()
                .Property(p => p.Nom)
                .IsRequired()
                .HasMaxLength(50);

        }


               
        }

}

