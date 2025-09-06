using System.Text.Json.Serialization;

namespace InvMIS.Domain.Entities
{
    public class Supplier
    {
        public int Id { get; set; }                     // Primary Key
        public string Name { get; set; } = null!;      // Supplier Name
        public string? ContactInfo { get; set; }       // Optional Contact Info

        // Navigation Property (initialize to avoid null reference)
        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
