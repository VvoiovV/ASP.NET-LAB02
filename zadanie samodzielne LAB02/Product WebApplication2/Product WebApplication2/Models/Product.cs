namespace Product_WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; } // Id dla identyfikacji produktu
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
