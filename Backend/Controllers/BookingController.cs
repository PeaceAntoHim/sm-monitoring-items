using Microsoft.AspNetCore.Mvc;

using sm_monitoring_items.Backend.DTOs;
using sm_monitoring_items.Backend.Models;
using sm_monitoring_items.Backend.Repositories;
using sm_monitoring_items.Backend.Helpers;


namespace sm_monitoring_items.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase
{
    private readonly IBookingRepository _bookingRepo;

    public BookingController(IBookingRepository bookingRepo)
    {
        _bookingRepo = bookingRepo;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateBooking([FromBody] BookingRequestDto dto)
    {
        var requesterId = User.GetUserId();
        var booking = new BookingRequest
        {
            RequesterId = requesterId,
            VehicleId = dto.VehicleId,
            DriverId = dto.DriverId,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate,
            Purpose = dto.Purpose
        };
        var created = await _bookingRepo.CreateBookingAsync(booking, dto.Approver1Id, dto.Approver2Id);
        return Ok(created);
    }

    [HttpPost("approve")]
    public async Task<IActionResult> Approve([FromBody] ApprovalDto dto)
    {
        var approverId = User.GetUserId();
        var success = await _bookingRepo.ApproveBookingAsync(dto.BookingRequestId, approverId, dto.ApprovalLevel, dto.Approved);
        return success ? Ok("Updated") : BadRequest("Not found or unauthorized");
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAllBookings()
    {
        var bookings = await _bookingRepo.GetBookingsAsync();
        return Ok(bookings);
    }
}