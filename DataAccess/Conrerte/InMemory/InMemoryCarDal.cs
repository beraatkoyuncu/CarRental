using DataAccess.Abstract;
using Entities.Conrerte;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conrerte.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //class'ın içinde ama metotların dışında olduğu için bu class'ın global değişkeni denir.bu yüzden _ ile tanımlanır.
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, CarName="Focus", ColorId=1, DailyPrice=200, ModelYear=2015, Description="."},
                new Car{CarId=2, BrandId=1, CarName="Fiesta", ColorId=1, DailyPrice=150, ModelYear=2014, Description="."},
                new Car{CarId=3, BrandId=2, CarName="Doblo", ColorId=1, DailyPrice=160, ModelYear=2016, Description="."},
                new Car{CarId=4, BrandId=2, CarName="Egea", ColorId=1, DailyPrice=180, ModelYear=2018, Description="."},
                new Car{CarId=5, BrandId=3, CarName="Megane", ColorId=1, DailyPrice=220, ModelYear=2019, Description="."},
                new Car{CarId=6, BrandId=3, CarName="Clio", ColorId=1, DailyPrice=170, ModelYear=2017, Description="."}
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

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
