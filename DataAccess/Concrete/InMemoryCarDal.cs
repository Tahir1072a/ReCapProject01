using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() 
            { 
                new Car{CarId = 1,BrandId = 1, ColorId = 1,DailyPrice = 90, ModelYear = "2002", Description ="Kazasız temiz Araba"}
            
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            _cars.Remove(_cars.SingleOrDefault(p => p.CarId == id));
        }

        public List<Car> GetAll()
        {
            return _cars;   
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.BrandId == id).ToList();
        }

        public void Update(Car carId)
        {
           var carToUpdate =  _cars.SingleOrDefault(p => p.CarId == carId.CarId);
           carToUpdate.BrandId = carId.BrandId;
           carToUpdate.ModelYear = carId.ModelYear;
           carToUpdate.Description = carId.Description;
           carToUpdate.DailyPrice = carId.DailyPrice;
           carToUpdate.ColorId = carId.ColorId;
        }
    }
}
