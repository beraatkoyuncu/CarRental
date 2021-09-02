using Business.Abstract;
using DataAccess.Abstract;
using Entities.Conrerte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conrerte
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
