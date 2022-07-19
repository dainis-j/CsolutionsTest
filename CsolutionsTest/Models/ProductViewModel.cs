using System.ComponentModel;

namespace CsolutionsTest.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Units { get; set; }

        [DisplayName("Price with VAT (PVN)")]
        public decimal PriceWithVat
        {
            get => this.Price * this.Units * (1.21M); // Hard-coded for now
        }
    }
}
