﻿using Entities.Conrerte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GeyById(int BrandId);

    }
}
