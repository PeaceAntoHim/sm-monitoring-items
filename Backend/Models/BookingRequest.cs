
namespace sm_monitoring_items.Backend.Models;

public class BookingRequest
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? RequesterId { get; set; }
    public User Requester { get; set; }
    public Guid VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    public Guid DriverId { get; set; }
    public Driver Driver { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Purpose { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected

    public ICollection<Approval> Approvals { get; set; } = new List<Approval>();
}