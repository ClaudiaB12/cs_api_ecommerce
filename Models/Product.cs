using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEcommerce.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
        public required string description { get; set; }
        public decimal price { get; set; }
        public int stock { get; set;   }
    }
}