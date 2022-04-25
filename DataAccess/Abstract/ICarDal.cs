using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepostroy<Car>
    {
        List<CarDetailsDto> GetCarDetails();
       
    }
}
