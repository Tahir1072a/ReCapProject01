using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.CarId = 2;
            car.BrandId = 3;
            car.Description = "Aslanapa";
            car.DailyPrice = 900;
            car.ColorId = 2;
            car.ModelYear = "2000";
            ICarService carService = new CarManager(new InMemoryCarDal());
            foreach (var item in carService.GetAll())
            {
                Console.WriteLine(item.ModelYear);
            }

            carService.Add(car);
            carService.Delete(1);
        }
    }
}
