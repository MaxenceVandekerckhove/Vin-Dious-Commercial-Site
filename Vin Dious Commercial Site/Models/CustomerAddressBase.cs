using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class CustomerAddressBase
    {
        [Key]
        public int address_id { get; set; }
        [Required]
        public string city { get; set; }
        public int zipcode { get; set; }
        public string address { get; set; }
        public int firstname { get; set; }
        public string lastname { get; set; }
        public WebUserBase user_id { get; set; }

    }
}
