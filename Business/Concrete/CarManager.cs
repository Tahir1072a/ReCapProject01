using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            //İş kodları
            _carDal.Add(car);
        }

        public void Delete(int id)
        {
            _carDal.Delete(id);
        }

        public List<Car> GetAll()
        {
            //İş kodları
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public void Update(Car car)
        {
            // İş kodları
            _carDal.Update(car);
        }
    }
}
