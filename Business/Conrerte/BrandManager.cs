﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Conrerte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conrerte
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GeyById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }
    }
}
