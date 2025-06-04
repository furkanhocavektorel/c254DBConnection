
namespace FirstDBConnection.dto
{
    public class ProductCreateRequestDto
    {
        public String Name { get; set; }
        public short Stock { get; set; }
        public decimal Price { get; set; }
        public bool Discontinued { get; set; }
    }
}
