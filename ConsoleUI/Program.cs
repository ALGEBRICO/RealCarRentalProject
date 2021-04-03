using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var item in carManager.GetByDailyPrice(100,200))
            {
                Console.WriteLine(item.CarId+ " " +item.Description);
            }
            
        }
    }
}
