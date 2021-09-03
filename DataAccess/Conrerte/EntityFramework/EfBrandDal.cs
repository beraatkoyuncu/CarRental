using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conrerte;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Conrerte.EntityFramework
{
    public class EfBrandDal :EfEntityRepositoryBase<Brand,dbRentACarContext>,IBrandDal
    {
        
    }
}
