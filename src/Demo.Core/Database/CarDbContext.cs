using sDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core.Database
{
    public class CarDbContext : ICarDbContext
    {
        public List<Car> Cars { get; set; }
        public List<Enquiry> Enquiries { get; set; }

        public CarDbContext()
        {
            Cars = GetDummyCars();
        }

        private List<Car> GetDummyCars()
        {
            var cars = new List<Car>();
            cars.Add(new Car
            {
                Comments = GetDummyComments(),
                SellarType = SellarType.Dealer,
                Dealer = new Dealer("123 456 344", "Used Car"),
                Email = "info@toyota.com",
                Id = 1,
                ImageFile = "toyota_camry.jpg",
                Make = "Toyota",
                Model = "Camry",
                Price = 20000,
                Year = 2014
            });

            cars.Add(new Car
            {
                Comments = GetDummyComments(),
                SellarType = SellarType.Dealer,
                Dealer = new Dealer("123 456 344", "Used Car"),
                Email = "info@audi.com",
                Id = 2,
                ImageFile = "audi_Cabriolet.jpg",
                Make = "Audi",
                Model = "Cabriolet",
                Price = 20000,
                Year = 2015
            });

            cars.Add(new Car
            {
                Comments = GetDummyComments(),
                SellarType = SellarType.Dealer,
                Dealer = new Dealer("123 456 344", "Used Car"),
                Email = "info@audi.com",
                Id = 3,
                ImageFile = "audi_Cabriolet.jpg",
                Make = "Audi",
                Model = "Cabriolet",
                Price = 20000,
                Year = 2015
            });

            cars.Add(new Car
            {
                Comments = GetDummyComments(),
                SellarType = SellarType.Private,
                PrivateSellar = new Sellar("Amrita Z", "0456789098"),
                Email = "info@bmw.com",
                Id = 4,
                ImageFile = "bmw_320d.jpg",
                Make = "BMW",
                Model = "320d",
                Price = 558790,
                Year = 2016
            });

            cars.Add(new Car
            {
                Comments = GetDummyComments(),
                SellarType = SellarType.Private,
                PrivateSellar = new Sellar("Amrita Z", "0456789098"),
                Email = "info@kia.com",
                Id = 5,
                ImageFile = "kia_rio.jpg",
                Make = "Kia",
                Model = "Rio",
                Price = 23000,
                Year = 2015
            });


            cars.Add(new Car
            {
                Comments = GetDummyComments(),
                SellarType = SellarType.Private,
                PrivateSellar = new Sellar("Amrita Z", "0456789098"),
                Email = "info@suzuki.com",
                Id = 6,
                ImageFile = "suzuki_baleno.jpg",
                Make = "Suzuki",
                Model = "Baleno",
                Price = 23000,
                Year = 2015
            });


            cars.Add(new Car
            {
                Comments = GetDummyComments(),
                SellarType = SellarType.Dealer,
                Dealer = new Dealer("123 456 344", "Used Car"),
                Email = "info@mecedesbenz.com",
                Id = 7,
                ImageFile = "mercedes_benz_300gd.jpg",
                Make = "Mercedes-benz",
                Model = "300GD",
                Price = 78690,
                Year = 2015
            });


            return cars;
        }

        private string GetDummyComments()
        {
            return
                @"<p>Looking for your first car? Then this is the perfect car for you!   Looking for a car that provides great responsibility to the environment ? Then this is it.
                Toyota Corolla Ascent Sport 5Dr H / Back Manual Still under new car warranty, with only 26, 391 km on the clock, factory fitted XPACK with tinted windows, floor mats , boot liner, it represents great value at $18,500.Bluetooth capability that allows you to make hands free phone calls while driving.Selling due to owner moving OS.</p>
                <p> Features first car buyers will love:</p> <ul>  <li> USB audio input</li>
               <li> Air conditioning </li>
               <li> Cruise control </li>
               <li> An inbuilt bluetooth phone system </li>
               <li> Front cup holders </li>
                <li> IPod connectivity </li>
              <li> Storage compartment in centre console </li>
               <li> Front & amp; rear power windows </li>
               <li> Electric power assisted steering </li>
                </ul>
                <p> FOR THAT ADDED PEACE OF MIND </p>
                <p> An ANCAP safety rating of 5 so you can be sure you are driving with utmost safety.This Toyota Corolla has driver airbag, side airbags, knee airbag for driver and passenger airbag.It has 7 airbags fitted for your safety. Last but not least this car has parking assist graphical display. </p>
                26391 km on the clock only.This car is priced to sell quickly at $18, 500.
                <p> FEATURES YOU WILL LOVE </p>
                Strong ABS brakes.Rear view camera, remote central locking and power door mirrors.</p> ";
        }

    }
}
