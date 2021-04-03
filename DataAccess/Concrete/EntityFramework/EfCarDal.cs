using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {

        public void Add(Car car)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                if (car.Description.Length > 2 && car.DailyPrice > 0)
                {
                    var addedEntity = context.Entry(car);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }

            }
        }

        public void Delete(Car car)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        //public List<Car> GetAll()
        //{
        //    return new List<Car> { new Car { Description = "Tofaşşş" }, new Car { Description = "Renooo" } };
        //}

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetById(int brandId, int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                var updatedEntity = context.Entry(car);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
