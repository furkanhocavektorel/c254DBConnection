
using FirstDBConnection.controller;
using FirstDBConnection.dto;
using FirstDBConnection.entity;
using FirstDBConnection.service;

namespace FirstDBConnection
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            CategoryService categoryService = new CategoryService();

            CategoryUpdateRequestDto dto1 = new CategoryUpdateRequestDto();

            dto1.CategoryName = "balik";
            dto1.CategoryID = 1;
            dto1.Description = "Testdesc";

            categoryService.update(dto1);













            CategoryController categoryController = new CategoryController();

            CategoryCreateRequestDto dto = new CategoryCreateRequestDto();

            dto.CategoryName = "asd";
            dto.Desc = "ss";



            List<CategoryResponseDto> categoryList=categoryController.GetCategories();
            foreach (CategoryResponseDto item in categoryList)
            {
                Console.WriteLine(item.ToString());
            }








            Console.WriteLine("******* soft delete ********");
            categoryController.softDeleteCategory(3);
            List<CategoryResponseDto> categoryList2 = categoryController.GetCategories();

            foreach (CategoryResponseDto item in categoryList2)
            {
                Console.WriteLine(item.ToString());
            }



            //Console.WriteLine("******* hard delete ********");
            //categoryController.hardDeleteCategory(14);
            //List<CategoryResponseDto> categoryList3 = categoryController.GetCategories();

            //foreach (CategoryResponseDto item in categoryList3)
            //{
            //    Console.WriteLine(item.ToString());
            //}


        }
    }
}
