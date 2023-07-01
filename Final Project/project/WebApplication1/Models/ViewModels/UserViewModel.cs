using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]   
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Password Do Not Match Please Check Again")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } 

       
    }
}
