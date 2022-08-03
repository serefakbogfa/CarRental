using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
   public class RentalDto : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Customer { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
