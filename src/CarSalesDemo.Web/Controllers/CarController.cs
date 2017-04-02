using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Core.Services;
using CarSalesDemo.Web.ViewModels;
using CarSalesDemo.Web.Infrastructure;

namespace CarSalesDemo.Web.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public IActionResult Index()
        {
            var model = new CarListingViewModel();
            var availableCars = _carService.GetCars();
            model.Cars = availableCars.Select(m => Mapper.MapFromDbEntity(m)).ToList();
            return View(model);
        }

        public IActionResult Details(int carId)
        {
            var car = _carService.GetCarById(carId);
            return View("CarDetails", Mapper.MapFromDbEntity(car));
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
