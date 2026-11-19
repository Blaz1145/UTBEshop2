using UTBEshop2.Domain.Entities;

namespace UTBEshop2.Application.Abstraction
{
    public interface IProductAppService
    {
        IList<Product> SelectAll();
    }
}