
using System.ComponentModel.DataAnnotations;


namespace Vin_Dious_Commercial_Site.Models
{
    public class ProductBrandBase
    {
        [Key]
        public int brand_id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }

    }
}
