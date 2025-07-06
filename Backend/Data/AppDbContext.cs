using Microsoft.EntityFrameworkCore;
using sm_monitoring_items.Backend.Models;

namespace sm_monitoring_items.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<BookingRequest> BookingRequests { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }
        public DbSet<FuelConsumption> FuelConsumptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optional Fluent Configurations
            modelBuilder.Entity<BookingRequest>()
                .HasMany(b => b.Approvals)
                .WithOne()
                .HasForeignKey(a => a.BookingRequestId);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}