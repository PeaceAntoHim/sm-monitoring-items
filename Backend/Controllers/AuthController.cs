using Microsoft.AspNetCore.Mvc;

using sm_monitoring_items.Backend.DTOs;
using sm_monitoring_items.Backend.Repositories;

namespace sm_monitoring_items.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthRepository _authRepo;

    public AuthController(IAuthRepository authRepo)
    {
        _authRepo = authRepo;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (!await _authRepo.ValidateUserAsync(request.Email, request.Password))
            return Unauthorized("Invalid credentials");

        var user = await _authRepo.GetByEmailAsync(request.Email);
        var token = await _authRepo.GenerateJwtTokenAsync(user!);
        return Ok(new { token });
    }
}
