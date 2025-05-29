

using FirstDBConnection.dto;
using FirstDBConnection.entity;

namespace FirstDBConnection.mapper
{
    public class CategoryMapper
    {

        public CategoryResponseDto categoryToCategoryResponseDto(Category entity)
        {
            CategoryResponseDto dto = new CategoryResponseDto();

            dto.CategoryID = entity.CategoryID;
            dto.Description = entity.Description;
            dto.CategoryName = entity.CategoryName;
            return dto;
        }
    }
}
