namespace sm_monitoring_items.Backend.Models;

public class Approval
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BookingRequestId { get; set; }
    public BookingRequest? BookingRequest { get; set; }
    public Guid ApproverId { get; set; }
    public User? Approver { get; set; }
    public int ApprovalLevel { get; set; } // 1 or 2
    public bool? Approved { get; set; }
    public DateTime? ApprovedAt { get; set; }
}