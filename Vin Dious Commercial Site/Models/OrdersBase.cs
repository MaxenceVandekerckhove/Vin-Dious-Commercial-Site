using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class OrdersBase
    {
        [Key]
        public int orders_id { get; set; }
        [Required]
        public decimal price { get; set; }
        public string order_date { get; set; }
        public int quantity { get; set; }
        public OrderStatusBase status_id { get; set; }
        public WebUserBase user_id { get; set; }
    }
}

