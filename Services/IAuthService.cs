using ApiEcommerce.Models;
using ApiEcommerce.Requests;

namespace ApiEcommerce.Services
{
    public interface IAuthService
    {
        Task<User?> ValidateUserAsync(LoginRequest request);
    }
}