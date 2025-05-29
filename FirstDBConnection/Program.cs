
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

            Console.WriteLine(categoryController.GetCategoryById(5).ToString());

        }
    }
}
