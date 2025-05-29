
using FirstDBConnection.dto;
using FirstDBConnection.entity;
using FirstDBConnection.service;

namespace FirstDBConnection.controller
{
    public class CategoryController
    {
        CategoryService categoryService;
        public CategoryController()
        {
            categoryService = new CategoryService();
        }


        public List<CategoryResponseDto> GetCategories() {

            return categoryService.GetCategoriesList();
        }

        public CategoryResponseDto GetCategoryById(int id) { 
        
            return categoryService.GetCategoryById(id);
        }

    }
}
