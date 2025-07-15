using ApiEcommerce.Requests;

namespace ApiEcommerce.Services
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterRequest request);
    }
}