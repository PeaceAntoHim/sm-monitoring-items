// using Microsoft.EntityFrameworkCore;
// using sm_monitoring_items.Backend.Data;
// using sm_monitoring_items.Backend.Helpers;
// using sm_monitoring_items.Backend.Models;
// using sm_monitoring_items.Backend.Repositories;
//
// namespace sm_monitoring_items.Backend.Services;
//
// public class AuthService : IAuthRepository
// {
//     private readonly AppDbContext _context;
//     private readonly JwtHelper _jwtHelper;
//
//     public AuthService(AppDbContext context, JwtHelper jwtHelper)
//     {
//         _context = context;
//         _jwtHelper = jwtHelper;
//     }
//
//     public async Task<User?> GetByEmailAsync(string email) =>
//         await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
//
//     public async Task<bool> ValidateUserAsync(string email, string password)
//     {
//         var user = await GetByEmailAsync(email);
//         return user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
//     }
//
//     public async Task<string> GenerateJwtTokenAsync(User user) =>
//         await Task.FromResult(_jwtHelper.GenerateToken(user));
// }
