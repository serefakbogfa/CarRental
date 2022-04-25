using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepostroy<Customer>
    {
        List<CustomersDetailsDto> GetCustomerDetails();
    }
}
