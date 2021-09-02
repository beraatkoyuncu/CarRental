using Entities.Conrerte;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal : DataAccessLayer - veri erisim katmani (Dao olarak da kullanılıyor)
    //Car tablosunun veri erisim katmani
    public interface ICarDal
    {
        //interface metotlari default public

        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetById(int Id);

        List<Car> GetAllByBrand(int BrandId);//arabalari markaya göre filtrele

    }
}
