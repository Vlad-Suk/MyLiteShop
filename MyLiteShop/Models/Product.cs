using System.ComponentModel.DataAnnotations.Schema;

namespace MyLiteShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public int NumberOfProducts { get; set; } 
        public string? Description { get; set; }
    }
}
