

using FirstDBConnection.dto;
using FirstDBConnection.entity;

namespace FirstDBConnection.mapper
{
    public class ProductMapper
    {
        public Product map(ProductCreateRequestDto dto)
        {
            Product product = new Product();
            product.ProductName=dto.Name;
            product.Discontinued=dto.Discontinued;
            product.UnitPrice = dto.Price;
            product.UnitsInStock = dto.Stock;

            return product;
        }


        public ProductResponseDto map(Product product)
        {
            ProductResponseDto result = new ProductResponseDto();
            result.ProductName = product.ProductName;
            result.ProductID = product.ProductID;
            result.UnitPrice = product.UnitPrice;
            result.UnitsInStock= product.UnitsInStock;

            if (product.Category !=null)
            {
                result.CategoryName = product.Category.CategoryName;

            }
            else
            {
                result.CategoryName = null;
            }
            return result;
        }

    }
}
