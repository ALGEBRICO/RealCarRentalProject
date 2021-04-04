using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<CarDetailDTO> GetCarDetails();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

    }
}
