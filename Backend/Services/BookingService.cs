// using Microsoft.EntityFrameworkCore;
// using sm_monitoring_items.Backend.Data;
// using sm_monitoring_items.Backend.Models;
// using sm_monitoring_items.Backend.Repositories;
//
// namespace sm_monitoring_items.Backend.Services;
//
// public class BookingService : IBookingRepository
// {
//     private readonly AppDbContext _context;
//
//     public BookingService(AppDbContext context)
//     {
//         _context = context;
//     }
//
//     public async Task<BookingRequest> CreateBookingAsync(BookingRequest request, Guid approver1Id, Guid approver2Id)
//     {
//         _context.BookingRequests.Add(request);
//         await _context.SaveChangesAsync();
//
//         _context.Approvals.AddRange(new List<Approval>
//         {
//             new Approval { BookingRequestId = request.Id, ApproverId = approver1Id, ApprovalLevel = 1 },
//             new Approval { BookingRequestId = request.Id, ApproverId = approver2Id, ApprovalLevel = 2 },
//         });
//         await _context.SaveChangesAsync();
//
//         return request;
//     }
//
//     public async Task<IEnumerable<BookingRequest>> GetBookingsAsync() =>
//         await _context.BookingRequests.Include(v => v.Vehicle).Include(d => d.Driver).ToListAsync();
//
//     public async Task<BookingRequest?> GetBookingByIdAsync(Guid id) =>
//         await _context.BookingRequests.Include(a => a.Approvals).FirstOrDefaultAsync(x => x.Id == id);
//
//     public async Task<bool> ApproveBookingAsync(Guid bookingId, Guid approverId, int level, bool approved)
//     {
//         var approval = await _context.Approvals
//             .FirstOrDefaultAsync(a => a.BookingRequestId == bookingId && a.ApprovalLevel == level && a.ApproverId == approverId);
//
//         if (approval == null) return false;
//
//         approval.Approved = approved;
//         approval.ApprovedAt = DateTime.UtcNow;
//
//         var booking = await _context.BookingRequests.FirstOrDefaultAsync(b => b.Id == bookingId);
//         if (approved && level == 2) booking!.Status = "Approved";
//         else if (!approved) booking!.Status = "Rejected";
//
//         await _context.SaveChangesAsync();
//         return true;
//     }
// }
