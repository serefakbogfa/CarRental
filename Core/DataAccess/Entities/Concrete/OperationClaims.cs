using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Entities.Concrete
{
    public class OperationClaims : IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
