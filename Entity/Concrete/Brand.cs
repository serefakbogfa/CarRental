using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public String BrandName { get; set; }
    }
}
