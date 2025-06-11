
using FirstDBConnection.context;
using FirstDBConnection.dto;
using FirstDBConnection.entity;
using FirstDBConnection.entity.enums;
using FirstDBConnection.mapper;
using FirstDBConnection.repository.@abstract;
using FirstDBConnection.repository.concrete;
using FirstDBConnection.util;
using System.Net;

namespace FirstDBConnection.service
{
    public class CategoryService
    {
        ICategoryRepository repository;
        CategoryMapper categoryMapper;
        public CategoryService()
        {
            repository = new CategoryRepository();
            categoryMapper = new CategoryMapper();
        }
        // C.R.U.D
        // create,read,update,delete


        public CategoryResponseDto create(CategoryCreateRequestDto request)
        {
            Category? category = repository.getByName(request.CategoryName);
             
            if (category != null)
            {
                Console.WriteLine(request.CategoryName + " bu isimde kategori mevcut");
                return null;
            }

            category = categoryMapper.map(request);
         

            category=repository.Save(category);


            return categoryMapper.map(category);

        }


        public List<CategoryResponseDto> GetCategoriesList() {

            List<Category> categories = repository.GetAll();

            List<CategoryResponseDto> responseDtos = new List<CategoryResponseDto>();

            foreach (Category item in categories)
            {
                responseDtos.Add(categoryMapper.map(item));
            }

            return responseDtos;
        }

        public CategoryResponseDto GetById(int id) {

            return categoryMapper.map(repository.GetById(id));
            
        }


        public CategoryResponseDto update(CategoryUpdateRequestDto dto)
        {
            Category? category = repository.GetById(dto.CategoryID);


            if (category == null) {
                Console.WriteLine(dto.CategoryID+ "ye ait category mevcut degil...");
                return null;
            }
            /*target(hedef)=entity   source (kaynak)=dto
            //category.CategoryName = dto.CategoryName+"--companyName";
            category.Description= dto.Description;*/

            category = categoryMapper.map(dto);

            if (category == null) {
                throw new Exception("category update edilemedi!!!");
            }

         // TODO Repository'e update metodu yazılıp kullanılmalı.
            //context.Categories.Update(category);
            //context.SaveChanges();

            return categoryMapper.map(category);
        }

        public bool softDelete(int id)
        {
            Category? category = repository.GetById(id);

            if (category == null) {
                throw new Exception(id + " id'sine ait category bulunamadi!!!");
            }

            category.Status = StatusEnam.DELETED;

            // TODO Repository'e update metodu yazılıp kullanılmalı.
            //context.Categories.Update(category);
            //context.SaveChanges();
            return true;

        }


        public bool hardDelete(int id)
        {
            Category? category = repository.GetById(id);

            if (category == null)
            {
                throw new Exception(id + " id'sine ait category bulunamadi!!!");
            }
            // TODO Repository'de silme metodu yazılıp o çağrılmalı.
            //context.Categories.Remove(category);
            //context.SaveChanges();
            return true;

        }




    }
}
