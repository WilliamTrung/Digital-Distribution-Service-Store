using System;

namespace Product
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }  
        public Category Catagory { get; set; }
    }
}
