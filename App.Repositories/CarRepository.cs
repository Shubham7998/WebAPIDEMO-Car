using App.Data;
using App.IRepositories;
using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarDbContext dbContext) : base(dbContext)
        {
        }
    }
}
