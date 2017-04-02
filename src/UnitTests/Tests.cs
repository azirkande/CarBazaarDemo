using System;
using Xunit;
using Demo.Core;
using Demo.Core.Services;
using Demo.Core.Database;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void car_listing_should_show_cars() 
        {
            CarService carService = new CarService(new CarDbContext());
            var cars = carService.GetCars();
            Assert.Equal(cars.Count,7);
        }

        [Fact]
        public void car_details_should_fetch_right_car_details() 
        {
            CarService carService = new CarService(new CarDbContext());
            var car = carService.GetCarById(2);
            Assert.Equal(car.Year,2015);
            Assert.Equal(car.Make,"Audi");
        }
    }
}
