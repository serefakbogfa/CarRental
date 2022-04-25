using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conrete.EntityFramework
{
    public class EfUserDal : EfEntityFrameworkBase<User, ReCapContext>, IUserDal
    {
    }
}