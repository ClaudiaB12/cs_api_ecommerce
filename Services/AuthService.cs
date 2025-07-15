using ApiEcommerce.Data;
using ApiEcommerce.Models;
using ApiEcommerce.Requests;
using Microsoft.EntityFrameworkCore;

namespace ApiEcommerce.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> ValidateUserAsync(LoginRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.email == request.email && u.password == request.password);

            return user;    
        }
    }
}