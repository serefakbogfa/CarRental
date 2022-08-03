using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Entities.Concrete
{
    public class UserOperationClaims : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimsId { get; set; }
    }
}
