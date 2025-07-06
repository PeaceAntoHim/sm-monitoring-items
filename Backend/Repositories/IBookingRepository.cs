using sm_monitoring_items.Backend.Models;

namespace sm_monitoring_items.Backend.Repositories;

public interface IBookingRepository
{
    Task<BookingRequest> CreateBookingAsync(BookingRequest request, Guid approver1Id, Guid approver2Id);
    Task<IEnumerable<BookingRequest>> GetBookingsAsync();
    Task<BookingRequest?> GetBookingByIdAsync(Guid id);
    Task<bool> ApproveBookingAsync(Guid bookingId, string? approverId, int level, bool approved);
}