using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ViewModels
{
    public class LoginUserVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]   
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool IsPersisted { get; set; }   
    }
}
