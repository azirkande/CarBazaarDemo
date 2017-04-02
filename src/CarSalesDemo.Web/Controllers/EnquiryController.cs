using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarSalesDemo.Web.ViewModels;
using Demo.Core.Services;
using CarSalesDemo.Web.Infrastructure;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CarSalesDemo.Web.Controllers
{
    public class EnquiryController : Controller
    {
        private readonly IEnquiryService _enquiryService;
        public EnquiryController(IEnquiryService enquiryService)
        {
            _enquiryService = enquiryService;
        }
        [HttpPost]
        public IActionResult SaveEnquiry([FromBody]EnquiryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _enquiryService.Save(Mapper.MapToDbEntity(model));
                return View("_ThankYou");
            }
            else
            {
                return View("Error");
            }

        }
    }
}
