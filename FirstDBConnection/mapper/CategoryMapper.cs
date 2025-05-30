

using FirstDBConnection.dto;
using FirstDBConnection.entity;

namespace FirstDBConnection.mapper
{
    public class CategoryMapper
    {

        public CategoryResponseDto map(Category entity)
        {
            if (entity == null)
            {
                return null;
            }

            CategoryResponseDto dto = new CategoryResponseDto();

            dto.CategoryID = entity.CategoryID;
            dto.Description = entity.Description;
            dto.CategoryName = entity.CategoryName;
            return dto;
        }

        public Category map(CategoryUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return null;
            }
            Category category = new Category();
            category.CategoryID = dto.CategoryID;
            category.Description = dto.Description;
            category.CategoryName = dto.CategoryName+"--companyName";

            return category;
        }

    }
}
