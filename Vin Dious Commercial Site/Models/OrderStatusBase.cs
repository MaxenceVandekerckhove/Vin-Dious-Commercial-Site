

using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class OrderStatusBase
    {
        [Key]
        public int status_id { get; set; }
        [Required]
        public string name { get; set; }

    }
}
