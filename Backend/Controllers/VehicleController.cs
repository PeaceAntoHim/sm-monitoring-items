using Microsoft.AspNetCore.Mvc;
using sm_monitoring_items.Backend.Repositories;
namespace sm_monitoring_items.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleRepository _vehicleRepo;

    public VehicleController(IVehicleRepository vehicleRepo)
    {
        _vehicleRepo = vehicleRepo;
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var vehicles = await _vehicleRepo.GetAllAsync();
        return Ok(vehicles);
    }
}
