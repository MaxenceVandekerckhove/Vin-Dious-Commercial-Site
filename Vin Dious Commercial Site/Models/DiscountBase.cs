using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class DiscountBase
    {
        [Key]
        public int discount_id { get; set; }
        [Required]
        public string name { get; set; }
        public decimal discount_percent{ get; set; }
        public bool active { get; set; }
        public ProductBase product_id { get; set; }
    }
}

