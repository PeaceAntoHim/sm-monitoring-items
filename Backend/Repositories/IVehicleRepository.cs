using sm_monitoring_items.Backend.Models;

namespace sm_monitoring_items.Backend.Repositories;

public interface IVehicleRepository
{
    Task<IEnumerable<Vehicle>> GetAllAsync();
    Task<Vehicle?> GetByIdAsync(Guid id);
}