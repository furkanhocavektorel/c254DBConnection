
using FirstDBConnection.context;
using FirstDBConnection.dto;
using FirstDBConnection.entity;
using FirstDBConnection.entity.enums;
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
                responseDtos.Add(categoryMapper.map(item));
            }

            return responseDtos;
        }

        public CategoryResponseDto GetById(int id) {

            Category? category = context.Categories.
                SingleOrDefault(x => x.CategoryID == id);
            return categoryMapper.map(category);
            
        }

        public CategoryResponseDto create(CategoryCreateRequestDto request)
        {
            Category? category = context.Categories.FirstOrDefault
                (cat => cat.CategoryName.Equals(request.CategoryName));

            if (category != null)
            {
                Console.WriteLine(request.CategoryName+" bu isimde kategori mevcut");
                return null;
            }
            
            Category ca= new Category();

            ca.CategoryName = request.CategoryName;
            ca.Description = request.Desc;
            ca.Status = StatusEnam.ACTIVE;

            ca.CategoryName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Category cate =context.Categories.Add(ca).Entity;

            context.SaveChanges();

            return categoryMapper.map(cate);
        
        }

        public CategoryResponseDto update(CategoryUpdateRequestDto dto)
        {
            Category? category = context.Categories.Find(dto.CategoryID);


            if (category == null) {
                Console.WriteLine(dto.CategoryID+ "ye ait category mevcut degil...");
                return null;
            }
            /*target(hedef)=entity   source (kaynak)=dto
            //category.CategoryName = dto.CategoryName+"--companyName";
            category.Description= dto.Description;*/

            category = categoryMapper.map(dto);

         
            context.Categories.Update(category);
            context.SaveChanges();

            return categoryMapper.map(category);
        }

        public bool softDelete(int id)
        {
            Category? category = context.Categories.SingleOrDefault(x => x.CategoryID == id);

            if (category == null) {
                throw new Exception(id + " id'sine ait category bulunamadi!!!");
            }

            category.Status = StatusEnam.DELETED;

            context.Categories.Update(category);
            context.SaveChanges();
            return true;

        }


        public bool hardDelete(int id)
        {
            Category? category = context.Categories.SingleOrDefault(x => x.CategoryID == id);

            if (category == null)
            {
                throw new Exception(id + " id'sine ait category bulunamadi!!!");
            }

            context.Categories.Remove(category);
            context.SaveChanges();
            return true;

        }




    }
}
