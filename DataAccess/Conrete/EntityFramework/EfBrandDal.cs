using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conrete.EntityFramework
{
    public class EfBrandDal : EfEntityFrameworkBase<Brand,ReCapContext> ,IBrandDal
    { 
       
    }
}
