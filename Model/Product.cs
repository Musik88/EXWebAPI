using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EXWebAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public DateTime ProductCreated { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The product name cannot exceed {1} characters. ")]
        public string? ProductName { get; set; }

        [StringLength(200, ErrorMessage = "The product description cannot exceed {1} characters. ")]
        public string? ProductDescription { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProductPrice { get; set; }
    }
}

