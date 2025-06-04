
using FirstDBConnection.dto;
using FirstDBConnection.mapper;
using FirstDBConnection.service;

namespace FirstDBConnection.controller
{
    public class ProductController
    {
        ProductService productService;
        public ProductController()
        {
            productService = new ProductService();
        }


        public ProductResponseDto create(ProductCreateRequestDto dto)
        {
            return productService.create(dto);
        }

        public ProductResponseDto getById(int id)
        {
            return productService.getById(id);
        }

        public List<ProductResponseDto> getAll()
        {
            return productService.getAll();
        }


    }
}
