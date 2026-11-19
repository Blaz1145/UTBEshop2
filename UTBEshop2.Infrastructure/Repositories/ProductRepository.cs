using UTBEshop2.Domain.Entities;
using UTBEshop2.Domain.Repositories;
using UTBEshop2.Infrastructure.Database;

namespace UTBEshop2.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        public ProductRepository(EshopDbContext db) : base(db) 
        {
            /*  1. DI vytvára ProductRepository a dodá mu EshopDbContext.
                2. ProductRepository ho cez base(...) posunie do Repository.
                3. Repository si z neho uloží dbSet a dbContext. Odteraz fungujú GetAll, Add… 
                
                
                Co sa deje: 
                1. Pri vytvorení: DI vytvorí ProductRepository a dá mu EshopDbContext. Ten sa cez base(...) uloží do zdedených polí dbSet a dbContext. 
                Zatiaľ sa nič nenačítalo.
                2. Pri použití: AppService zavolá _productRepository.GetAll(). Spustí sa zdedená metóda z Repository, ktorá cez dbSet.ToList() až 
                teraz načíta produkty z MySQL a vráti ich AppService.*/
        }
    }
}