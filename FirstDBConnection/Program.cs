

using FirstDBConnection.context;
using FirstDBConnection.controller;
using FirstDBConnection.dto;
using FirstDBConnection.entity;
using Microsoft.EntityFrameworkCore;

namespace FirstDBConnection
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();

            ProductCreateRequestDto productCreateRequestDto = new ProductCreateRequestDto();
            productCreateRequestDto.Name = "klavye";
            productCreateRequestDto.Discontinued=false;
            productCreateRequestDto.Price = 5300;
            productCreateRequestDto.Stock = 500;
            productController.create(productCreateRequestDto);
        
        }
    }
}
