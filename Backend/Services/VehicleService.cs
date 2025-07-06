// using Microsoft.EntityFrameworkCore;
// using sm_monitoring_items.Backend.Data;
// using sm_monitoring_items.Backend.Models;
// using sm_monitoring_items.Backend.Repositories;
//
// namespace sm_monitoring_items.Backend.Services;
//
// public class VehicleService : IVehicleRepository
// {
//     private readonly AppDbContext _context;
//
//     public VehicleService(AppDbContext context)
//     {
//         _context = context;
//     }
//
//     public async Task<IEnumerable<Vehicle>> GetAllAsync() =>
//         await _context.Vehicles.ToListAsync();
//
//     public async Task<Vehicle?> GetByIdAsync(Guid id) =>
//         await _context.Vehicles.FindAsync(id);
// }