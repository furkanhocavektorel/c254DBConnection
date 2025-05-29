
using FirstDBConnection.context;
using FirstDBConnection.dto;
using FirstDBConnection.entity;
using FirstDBConnection.mapper;

namespace FirstDBConnection.service
{
    public class CategoryService
    {
        HepsiSuradaContext context;
        CategoryMapper categoryMapper;
        public CategoryService()
        {
            context = new HepsiSuradaContext();
            categoryMapper = new CategoryMapper();
        }
        // C.R.U.D
        // create,read,update,delete

        public List<CategoryResponseDto> GetCategoriesList() {

            List<Category> categories = context.Categories.ToList();

            List<CategoryResponseDto> responseDtos = new List<CategoryResponseDto>();

            foreach (Category item in categories)
            {
                responseDtos.Add(categoryMapper.categoryToCategoryResponseDto(item));
            }

            return responseDtos;
        }

        public CategoryResponseDto GetCategoryById(int id) {

            Category? category = context.Categories.
                SingleOrDefault(x => x.CategoryID == id);
            return categoryMapper.categoryToCategoryResponseDto(category);
            
        }


    }
}
