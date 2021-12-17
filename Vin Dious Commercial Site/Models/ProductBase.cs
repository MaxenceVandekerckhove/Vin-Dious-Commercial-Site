using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class ProductBase
    {
        [Key]
        public int product_id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public string creation_date { get; set; }
        public int quantity { get; set; }
        public SupplierBase supplier_id { get; set; }
        public ProductCategoryBase category_id { get; set; }
        public ProductBrandBase brand_id { get; set; }

    }
}
