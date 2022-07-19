using System.ComponentModel.DataAnnotations;

namespace CsolutionsTest.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Units { get; set; }
    }
}
