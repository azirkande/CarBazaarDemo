using CarSalesDemo.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesDemo.Web.ViewComponents
{
    public class Enquiry : ViewComponent
    {
        public IViewComponentResult Invoke(int carId)
        {
            return View(new EnquiryViewModel { CarId = carId });
        }
    }
}
