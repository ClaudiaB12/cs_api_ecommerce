using ApiEcommerce.Data;
using ApiEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEcommerce.Services
{
    public interface ICartService
    {
        Task<IEnumerable<Cart>> GetAllAsync();
        Task<Cart> SaveOrUpdateAsync(Cart cart);
    }

    public class CartService : ICartService
    {
        private readonly AppDbContext _context;

        public CartService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cart>> GetAllAsync()
        {
            return await _context.Carts.ToListAsync();
        }

        public async Task<Cart> SaveOrUpdateAsync(Cart cart)
        {
            var existing = await _context.Carts
                .FirstOrDefaultAsync(c => c.client == cart.client && c.product == cart.product);

            if (existing != null)
            {
                // Actualiza la cantidad
                existing.quantity += cart.quantity;
                _context.Carts.Update(existing);
                await _context.SaveChangesAsync();
                return existing;
            }
            else
            {
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
                return cart;
            }
        }

    }
}