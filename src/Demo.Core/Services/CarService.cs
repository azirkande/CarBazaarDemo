using Demo.Core.Database;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Core.Services
{
    public class CarService : ICarService
    {
        private readonly ICarDbContext _carDbContext;
        public CarService(ICarDbContext dbContext)
        {
            _carDbContext = dbContext;

        }
        public List<Car> GetCars()
        {
            return _carDbContext.Cars;
        }

        public Car GetCarById(int id)
        {
            return _carDbContext.Cars.FirstOrDefault(c => c.Id == id);
        }
    }
}
