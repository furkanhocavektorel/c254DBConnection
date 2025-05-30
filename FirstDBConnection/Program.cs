
using FirstDBConnection.controller;
using FirstDBConnection.dto;
using FirstDBConnection.entity;

namespace FirstDBConnection
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            CategoryController categoryController = new CategoryController();




            List<CategoryResponseDto> categoryList=categoryController.GetCategories();

            foreach (CategoryResponseDto item in categoryList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("*************\n\n");

            CategoryCreateRequestDto req= new CategoryCreateRequestDto();



            req.CategoryName = "süt";
            req.Desc = "süt ürünleri";



            CategoryCreateRequestDto req2 = new CategoryCreateRequestDto();

            req2.CategoryName = "süt";
            req2.Desc = "süt ürünleri";

            categoryController.createCategory(req);

            List<CategoryResponseDto> categoryList2 = categoryController.GetCategories();

            foreach (CategoryResponseDto item in categoryList2)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}
