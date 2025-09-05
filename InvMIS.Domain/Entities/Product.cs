namespace InvMIS.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }                  // Primary Key
        public string Name { get; set; }             // Product Name
        public string SKU { get; set; }              // Stock Keeping Unit
        public decimal Price { get; set; }           // Unit Price
        public int Quantity { get; set; }            // Available Quantity
        public string Description { get; set; }      // Optional

        // Foreign Keys
        public int CategoryId { get; set; }          // FK to Category
        public int SupplierId { get; set; }          // FK to Supplier

        // Navigation Properties
        public Category Category { get; set; } = null!;
        public Supplier Supplier { get; set; } = null!;
    }
}
