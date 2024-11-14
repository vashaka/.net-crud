using Microsoft.AspNetCore.Identity;

namespace OwnApp.Models
{
    public class MyUser : IdentityUser
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
