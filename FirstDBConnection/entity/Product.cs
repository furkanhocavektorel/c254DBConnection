﻿namespace FirstDBConnection.entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public bool Discontinued { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public Category? Category { get; set; }
        public short? ReorderLevel { get; set; }
    }
}
