namespace sm_monitoring_items.Backend.Models;

public class FuelConsumption
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    public DateTime RefuelDate { get; set; }
    public double Liters { get; set; }
    public double Cost { get; set; }
}