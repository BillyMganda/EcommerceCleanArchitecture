using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string email { get; set; } = string.Empty;
        [Required]
        public byte[] password_hash { get; set; } = new byte[32];
        [Required]
        public byte[] password_salt { get; set; } = new byte[32];
        [Required]
        public DateTime date_created { get; set; }
    }
}
