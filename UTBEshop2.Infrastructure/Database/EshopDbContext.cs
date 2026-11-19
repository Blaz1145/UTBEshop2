using Microsoft.EntityFrameworkCore;
using UTBEshop2.Domain.Entities;

namespace UTBEshop2.Infrastructure.Database
{
    public class EshopDbContext : DbContext //schopnost prace s databazou vdaka dedeniu
    {
        public DbSet<Product> Products { get; set; } //priadnie riadku DbSet pomocou entit 

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options) //option je parameter konstruktora s udajmi o databaze a connection string
        {
        }
    }
}