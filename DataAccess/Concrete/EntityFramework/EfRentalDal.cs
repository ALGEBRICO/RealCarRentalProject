using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RealCarRentalProjectContext>, IRentalDal
    {
        public List<RentalDetailDTO> GetRentalDetails()
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.CarId
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                    join usr in context.Users on customer.CustomerId equals usr.UserId
                    select new RentalDetailDTO
                    {
                        
                        RentId = rental.RentalId,
                        CompanyName = customer.ContactName,
                        CarName = car.CarName,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate
                    };

                return result.ToList();

            }
        }
    }
}

