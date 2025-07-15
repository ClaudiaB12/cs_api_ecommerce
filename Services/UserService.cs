using ApiEcommerce.Models;
using ApiEcommerce.Requests;
using ApiEcommerce.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiEcommerce.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterUserAsync(RegisterRequest request)
        {
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.email == request.email);

            if (existingUser != null)
            {
                return false; 
            }

            var newUser = new User
            {
                email = request.email,
                password = request.password,
                name = request.name,
                address = request.address,
                phone = request.phone
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
