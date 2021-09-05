using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conrerte;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conrerte.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, dbRentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (dbRentACarContext context=new dbRentACarContext())
            {
                var result = from c in context.tblCars
                             join b in context.tblBrands
                             on c.BrandId equals b.BrandId
                             join p in context.tblColors
                             on c.ColorId equals p.ColorId
                             select new CarDetailDto 
                             {
                                 CarId = c.CarId, 
                                 CarName = c.CarName, 
                                 BrandName = b.BrandName, 
                                 ColorName = p.ColorName, 
                                 DailyPrice = (short)c.DailyPrice 
                             };
                return result.ToList();

            }

        }
    }
}
