namespace InvMIS.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }            // Primary Key
        public string Name { get; set; }       // Product Name
        public string SKU { get; set; }        // Stock Keeping Unit
        public decimal Price { get; set; }     // Unit Price
        public int Quantity { get; set; }      // Available Quantity
        public string Description { get; set; }// Optional
    }
}
