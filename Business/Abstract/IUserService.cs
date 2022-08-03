using Core.DataAccess.Entities.Concrete;
using Core.DataAccess.Utilities.Results.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {  
             
        List<OperationClaims> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
