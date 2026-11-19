using UTBEshop2.Application.Abstraction;
using UTBEshop2.Domain.Entities;
using UTBEshop2.Domain.Repositories;

namespace UTBEshop2.Application.Implementation
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductAppService(IProductRepository productRepository) //DI si vypita rozhranie triedu
        {
            _productRepository = productRepository;
        }
        
        public IList<Product> SelectAll() // metóda vráti zoznam produktov
        {
            return _productRepository.GetAll().ToList();
        }
    }
}