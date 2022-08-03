using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conrete.EntityFramework
{
    public class EfCustomerDal : EfEntityFrameworkBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomersDetailsDto> GetCustomerDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Customers
                             join c2 in context.Users
                             on c.UserId equals c2.Id
                             select new CustomersDetailsDto()
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cu.CompanyName
                             };
                return result.ToList();

            }
        }
    }
}
