using FirstDBConnection.entity;
using FirstDBConnection.util;

namespace FirstDBConnection.repository
{
    public interface IProductRepository : IRepository<Product, int>
    {
        List<Product> getProductByPrice(int price);
    }
}
