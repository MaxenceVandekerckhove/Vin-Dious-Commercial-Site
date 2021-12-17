using System.ComponentModel.DataAnnotations;

namespace Vin_Dious_Commercial_Site.Models
{
    public class WebUserBase
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public RoleBase role_id { get; set; }

    }
}

