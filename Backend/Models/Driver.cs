namespace sm_monitoring_items.Backend.Models;

public class Driver
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string LicenseNumber { get; set; } = string.Empty;

    public ICollection<BookingRequest> BookingRequests { get; set; } = new List<BookingRequest>();
}