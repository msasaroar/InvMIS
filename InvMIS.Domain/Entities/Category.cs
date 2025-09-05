namespace InvMIS.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }                     // Primary Key
        public string Name { get; set; } = null!;      // Category Name
        public string? Description { get; set; }       // Optional Description

        // Navigation Property (initialize to avoid null reference)
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
