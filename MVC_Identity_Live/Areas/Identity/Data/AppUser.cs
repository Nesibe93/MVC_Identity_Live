using Microsoft.AspNetCore.Identity;

namespace MVC_Identity_Live.Areas.Identity.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; } // Yeni Alan

        public int PhoneNumber { get; set; }
    }
}
