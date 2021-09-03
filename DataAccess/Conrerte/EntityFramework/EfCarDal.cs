using DataAccess.Abstract;
using Entities.Conrerte;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conrerte.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            //IDispossable pattern implementation of c#
            //NorthwindContext işi bittiğinde bellekte yer kaplamasın diye using içinde kullandım.
            using (dbRentACarContext context = new dbRentACarContext())
            {
                var addedEntity = context.Entry(entity);//referansı yakala
                addedEntity.State = EntityState.Added;//eklenecek nesne olduğunu belirttik
                context.SaveChanges();

            }
        }

        public void Delete(Car entity)
        {
            using (dbRentACarContext context = new dbRentACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (dbRentACarContext context=new dbRentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (dbRentACarContext context = new dbRentACarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
                
            }
        }

        public void Update(Car entity)
        {
            using (dbRentACarContext context = new dbRentACarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
