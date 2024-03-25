using App.Model;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
    }
}
