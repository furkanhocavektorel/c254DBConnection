namespace FirstDBConnection.dto
{
    public class ProductResponseDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string? CategoryName { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }

    }
}
