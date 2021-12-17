using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class OrdersInventoryBase
    {
        [Key]
        public int inventory_id { get; set; }
        [Required]
        public SupplierBase supplier_id { get; set; }
        public ProductBase product_id { get; set; }
        public int quantity { get; set; }
        public OrderStatusBase status_id { get; set; }
    }
}

