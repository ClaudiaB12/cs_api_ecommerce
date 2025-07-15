using Microsoft.EntityFrameworkCore;
using ApiEcommerce.Models;

namespace ApiEcommerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products => Set<Product>();

        public DbSet<Cart> Carts { get; set; }
    }

}