using sm_monitoring_items.Backend.Models;

namespace sm_monitoring_items.Backend.Repositories;

public interface IAuthRepository
{
    Task<User?> GetByEmailAsync(string email);
    Task<bool> ValidateUserAsync(string email, string password);
    Task<string> GenerateJwtTokenAsync(User user);
}