using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEcommerce.Models
{
    [Table("usr")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
        public required string name { get; set; }
        public required string address { get; set; }
        public required string phone { get; set; }
    }

}