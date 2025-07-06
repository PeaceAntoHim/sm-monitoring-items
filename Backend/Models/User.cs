namespace sm_monitoring_items.Backend.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Role { get; set; } = "User"; // Admin or Approver

    public ICollection<Approval> Approvals { get; set; } = new List<Approval>();
    public ICollection<BookingRequest> Requests { get; set; } = new List<BookingRequest>();
}