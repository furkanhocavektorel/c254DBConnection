using FirstDBConnection.entity;
using FirstDBConnection.util;

namespace FirstDBConnection.repository.@abstract
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
        Category? getByDesc(string desc);
        Category? getByName(string name);
    }
}
