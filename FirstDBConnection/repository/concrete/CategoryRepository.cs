using Azure.Core;
using FirstDBConnection.context;
using FirstDBConnection.entity;
using FirstDBConnection.entity.enums;
using FirstDBConnection.repository.@abstract;
using FirstDBConnection.util;

namespace FirstDBConnection.repository.concrete
{
    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        HepsiSuradaContext context;
        public CategoryRepository()
        {
            context = new HepsiSuradaContext();
        }

        public Category? getByDesc(string desc)
        {
            return context.Categories.FirstOrDefault(x => x.Description.Equals(desc));
        }

        public Category? getByName(string name)
        {
           return context.Categories.FirstOrDefault
                (cat => cat.CategoryName.Equals(name));
        }
    }
}
