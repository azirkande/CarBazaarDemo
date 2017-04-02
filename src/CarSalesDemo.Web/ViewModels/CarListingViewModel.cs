using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesDemo.Web.ViewModels
{
    public class CarListingViewModel
    {
        public CarListingViewModel()
        {
            Cars = new List<CarViewModel>();
        }
        public List<CarViewModel> Cars { get; set; }
    }
}
