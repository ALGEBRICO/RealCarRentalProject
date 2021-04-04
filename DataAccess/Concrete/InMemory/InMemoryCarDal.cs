using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=2,ColorId=1,DailyPrice=1550,Description="Porsh",ModelYear=1960}
                ,new Car{CarId =1,BrandId=2,ColorId=2,DailyPrice=2550,Description="APorsh",ModelYear=1970}
                ,new Car{CarId=1,BrandId=3,ColorId=3,DailyPrice=4550,Description="BPorsh",ModelYear=1980}
                ,new Car{CarId =1,BrandId=4,ColorId=4,DailyPrice=3550,Description="CPorsh",ModelYear=1990}
                ,new Car{CarId =1,BrandId=2,ColorId=5,DailyPrice=2550,Description="DPorsh",ModelYear=1995}
                ,new Car{CarId =1,BrandId=1,ColorId=6,DailyPrice=6550,Description="EPorsh",ModelYear=1996}
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId, int colorId)
        {
            return _cars.Where(c => c.BrandId == brandId && c.ColorId== colorId).ToList();
            
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
