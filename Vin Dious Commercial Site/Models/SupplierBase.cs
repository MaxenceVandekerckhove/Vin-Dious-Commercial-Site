using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class SupplierBase
    {
        [Key]
        public int supplier_id { get; set; }
        [Required]
        public string name { get; set; }
        public string prenom { get; set; }
        public string address { get; set; }
        public int zipcode { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        
    }
}
