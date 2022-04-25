﻿using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public String Description { get; set; }
    }
}
