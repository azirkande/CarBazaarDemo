using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core.Services
{
    public interface ICarService
    {
        List<Car> GetCars();
        Car GetCarById(int id);
    }
}
