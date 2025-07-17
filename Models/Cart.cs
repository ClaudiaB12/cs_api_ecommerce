using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEcommerce.Models
{
    [Table("cart")]
    public class Cart
    {
        [Key]
        public int id { get; set; }

        public required int client { get; set; }

        [ForeignKey("client")]
        public User? ClientNav { get; set; }  
        public required int product { get; set; }

        [ForeignKey("product")]
        public Product? ProductNav { get; set; }  

        public required int quantity { get; set; }
    }
}
