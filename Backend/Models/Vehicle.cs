namespace sm_monitoring_items.Backend.Models;

public class Vehicle
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty; // Angkutan Orang / Barang
    public bool IsRented { get; set; }
    public string FuelType { get; set; } = string.Empty;
    public int Capacity { get; set; }

    public ICollection<ServiceRecord> ServiceRecords { get; set; } = new List<ServiceRecord>();
    public ICollection<FuelConsumption> FuelConsumptions { get; set; } = new List<FuelConsumption>();
    public ICollection<BookingRequest> BookingRequests { get; set; } = new List<BookingRequest>();
}