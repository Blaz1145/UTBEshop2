using Microsoft.EntityFrameworkCore;
using UTBEshop2.Domain.Entities;
using UTBEshop2.Infrastructure.Database.Seeding;

namespace UTBEshop2.Infrastructure.Database
{
    public class EshopDbContext : DbContext //schopnost prace s databazou vdaka dedeniu
    {
        public DbSet<Product> Products { get; set; } //priadnie riadku DbSet pomocou entit 

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options) //option je parameter konstruktora s udajmi o databaze a connection string
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //metoda ktoru vola EF Core pri skladani modelu datavazy

            var productInit = new ProductInit();
            var products = productInit.GetProductsFood3();
            modelBuilder.Entity<Product>().HasData(products); //urcuje co ma byt v tabulke Products
        }
    }
}