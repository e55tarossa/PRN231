using System;

namespace PRN231.Dto
{
    public class UserDto
    {
        public Guid userID { get; set; }
        public string Email { get; set; }
        public string userName { get; set; }
        public string Address { get; set; }
        public bool isAdmin { get; set; } = false;
    }
}
