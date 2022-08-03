using Core.DataAccess;
using Core.DataAccess.Entities.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepostroy<User>
    {
        List<OperationClaims> GetClaims(User user);
    }
}
