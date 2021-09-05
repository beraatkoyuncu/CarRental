using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conrerte;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conrerte.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, dbRentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (dbRentACarContext context = new dbRentACarContext())
            {
                var result = from cu in context.tblCustomers
                             join u in context.tblUsers
                             on cu.UserId equals u.UserId
                             join r in context.tblRentals
                             on cu.CustomerId equals r.CustomerId
                             select new CustomerDetailDto
                             {
                                 CustomerId = cu.CustomerId,
                                 CompanyName = cu.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
