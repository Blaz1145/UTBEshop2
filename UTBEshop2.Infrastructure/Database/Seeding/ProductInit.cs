using UTBEshop2.Domain.Entities;

namespace UTBEshop2.Infrastructure.Database.Seeding
{

    internal class ProductInit
    {
        public IList<Product> GetProductsFood3()
        {
            IList<Product> products = new List<Product>(); //IList<Product> je zoznam produktov. new List<Product>() vytvorí prázdny zoznam
            
            products.Add(new Product
            {
                Id = 1,
                Name = "Rohlik",
                Description = "najlepsi rohlik na svete",
                Price = 2,
                ImageUrl = "/img/products/produkty-01.jpg"
            });
            
            products.Add(new Product
            {
                Id = 2,
                Name = "Chleba",
                Description = "nejlepší chleba v galaxii",
                Price = 50,
                ImageUrl = "/img/products/produkty-02.jpg"
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "Bageta",
                Description = "nejlepší bageta ve vesmíru",
                Price = 40,
                ImageUrl = "/img/products/produkty-05.jpg"
            });
            
            return products;
        }
    }
}