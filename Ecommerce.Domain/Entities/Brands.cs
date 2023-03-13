using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities
{
    public class Brands
    {
        [Key]
        public int brand_id { get; set; }
        [Required]
        public string brand_name { get; set; } = string.Empty;
    }
}
