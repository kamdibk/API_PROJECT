using System;

namespace API_PROJECT.Models
{
    public class Products
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
