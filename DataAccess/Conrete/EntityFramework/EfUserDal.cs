using Core.DataAccess.Entities.Concrete;
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
        public List<OperationClaims> GetClaims(User user)
        {
            using (var context = new ReCapContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimsId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaims { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}