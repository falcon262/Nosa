using System;
using System.Collections.Generic;
using System.Text;

namespace PwC.Nosa.UserDtos
{
    public class UserInfoDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LOS { get; set; }
    }
}
