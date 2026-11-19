using UTBEshop2.Domain.Entities;

namespace UTBEshop2.Domain.Repositories
{

    public interface IProductRepository : IRepository<Product, int> //Dedi vsetky metody z Repositories(Interface)
    {
        //Rozhranie konkretne pre pripad Entity produktu mozu tu ist specialne metody ako hladanie podla mena
    }
}