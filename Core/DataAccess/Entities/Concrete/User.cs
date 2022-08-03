using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
