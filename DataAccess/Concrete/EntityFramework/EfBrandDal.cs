using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {

        public void Add(Brand brand)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                if (brand.BrandName.Length >2)
                {
                    var addedEntity = context.Entry(brand);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                
            }
        }

        public void Delete(Brand brand)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                var deletedEntity = context.Entry(brand);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RealCarRentalProjectContext context= new RealCarRentalProjectContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                return filter == null 
                    ? context.Set<Brand>().ToList() 
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand brand)
        {
            using (RealCarRentalProjectContext context = new RealCarRentalProjectContext())
            {
                var updatedEntity = context.Entry(brand);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
