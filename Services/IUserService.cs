using ApiEcommerce.Models;
using ApiEcommerce.Requests;

namespace ApiEcommerce.Services
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterRequest request);
        Task<User?> GetUserByIdAsync(int clientId);
    }
}