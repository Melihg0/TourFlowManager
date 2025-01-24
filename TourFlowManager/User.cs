using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourAgent
{
    internal class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoleID {  get; set; }
        public string PhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
