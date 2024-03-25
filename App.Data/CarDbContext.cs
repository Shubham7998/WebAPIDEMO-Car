using App.Model;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarType> CarsType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(c => c.CarType)
                .WithMany()
                .HasForeignKey(c => c.CarTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
