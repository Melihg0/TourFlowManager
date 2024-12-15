using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourAgent
{

    public static class UserSession
    {
        public static int UserID { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string PhoneNumber { get; set; }
        public static string UserPassword { get; set; }
        public static int RoleID { get; set; }
        public static DateTime BirthDate { get; set; }
        public static DateTime CreatedAt { get; set; }
    }

}

