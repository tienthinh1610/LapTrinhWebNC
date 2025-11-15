using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD

namespace SportsStore.Models
{
    public class Product
    {
        public long? ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        
        public string Category { get; set; } = string.Empty;
=======
namespace SportsStore.Models {
    public class Product {
        public long? ProductID { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public string Category { get; set; } = String.Empty;
>>>>>>> 607b160783a639cf95a18df2d91ab140a3189446
    }
}