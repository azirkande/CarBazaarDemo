using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core.Database
{
    public interface ICarDbContext
    {
        List<Car> Cars {get; set; }
        List<Enquiry> Enquiries { get; set; }
    }
}
