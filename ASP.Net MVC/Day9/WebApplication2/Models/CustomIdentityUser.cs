using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        public int Age { get; set; }
    }
}
