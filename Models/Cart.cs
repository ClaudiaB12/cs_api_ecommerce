using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEcommerce.Models
{
    [Table("cart")]
    public class Cart
    {
        [Key]
        public int id { get; set; }

        // Clave foránea hacia tabla usr
        public required int client { get; set; }

        [ForeignKey("client")]
        public User? ClientNav { get; set; }  // navegación hacia User (o Usr si se llama así)

        // Clave foránea hacia tabla product
        public required int product { get; set; }

        [ForeignKey("product")]
        public Product? ProductNav { get; set; }  // navegación hacia Product

        public required int quantity { get; set; }
    }
}
