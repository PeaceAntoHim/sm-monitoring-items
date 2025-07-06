namespace sm_monitoring_items.Backend.DTOs;

public class BookingRequestDto
{
    public Guid VehicleId { get; set; }
    public Guid DriverId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Purpose { get; set; } = string.Empty;
    public Guid Approver1Id { get; set; }
    public Guid Approver2Id { get; set; }
}

public class BookingResponseDto
{
    public Guid Id { get; set; }
    public string? VehicleName { get; set; }
    public string? DriverName { get; set; }
    public string? Purpose { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Status { get; set; }
}