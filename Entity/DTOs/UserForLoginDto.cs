using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{

    public class UserForLoginDto : IDto
    {
        public string email { get; set; }
        public string Password { get; set; }
    }
}
