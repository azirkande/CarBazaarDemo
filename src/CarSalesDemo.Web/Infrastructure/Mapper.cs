using CarSalesDemo.Web.ViewModels;
using Demo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesDemo.Web.Infrastructure
{
    public static class Mapper
    {

        public static Enquiry MapToDbEntity(EnquiryViewModel model)
        {
            if (model == null)
                return null;
            return new Enquiry
            {
                CarId = model.CarId,
                Email = model.Email,
                Name = model.Name
            };
        }

        public static CarViewModel MapFromDbEntity(Car car)
        {
            if (car == null)
                return null;
            return new CarViewModel
            {
                Comments = car.Comments,
                Dealer = car.Dealer,
                Email = car.Email,
                Id = car.Id,
                ImageFile = car.ImageFile,
                Make = car.Make,
                Model = car.Model,
                Price = car.Price,
                PrivateSellar = car.PrivateSellar,
                SellarType = car.SellarType,
                Year = car.Year
            };
        }
    }
}
