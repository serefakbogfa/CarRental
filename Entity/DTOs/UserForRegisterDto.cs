using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
  public  class UserForRegisterDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
