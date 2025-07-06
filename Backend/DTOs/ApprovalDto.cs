namespace sm_monitoring_items.Backend.DTOs;

public class ApprovalDto
{
    public Guid BookingRequestId { get; set; }
    public int ApprovalLevel { get; set; }
    public bool Approved { get; set; }
    public string? Note { get; set; }
}