
using FirstDBConnection.context;
using FirstDBConnection.dto;
using FirstDBConnection.entity;
using FirstDBConnection.mapper;

namespace FirstDBConnection.service
{
    public class ProductService
    {
        HepsiSuradaContext context;
        ProductMapper productMapper;
        public ProductService()
        {
            this.context = new HepsiSuradaContext();
            productMapper= new ProductMapper();
            
        }

        public ProductResponseDto create(ProductCreateRequestDto dto)
        {
            Product product = productMapper.map(dto);
            product.ProductName = "dolma"+ dto.Name;

            Product savedProduct =context.Products.Add(product).Entity;
            context.SaveChanges();

            ProductResponseDto responseDto = productMapper.map(savedProduct);
            return responseDto;
        }

        public ProductResponseDto getById(int id)
        {
            Product? product= context.Products.Find(id);
            return productMapper.map(product);
        }

        public List<ProductResponseDto> getAll() { 
        
            List<Product> products= context.Products.ToList();

            List<ProductResponseDto> dtos= new List<ProductResponseDto>();

            foreach (Product product in products) { 

                ProductResponseDto dto = productMapper.map(product);
                dtos.Add(dto);
            }
            return dtos;
        }


    }
}
