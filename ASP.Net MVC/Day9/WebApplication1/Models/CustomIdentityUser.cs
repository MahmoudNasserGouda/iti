using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        public int Age { get; set; }
    }
}
