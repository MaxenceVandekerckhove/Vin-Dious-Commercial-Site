using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class OrdersDetailsBase
    {
        [Key]
        public int order_details_id { get; set; }
        [Required]
        public ProductBase product_id { get; set; }
        [Required]
        public OrdersBase orders_id { get; set; }
        [Required]
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}

