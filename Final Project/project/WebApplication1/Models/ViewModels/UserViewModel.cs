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
		[RegularExpression(@"^(011|012|010|015)\d{8}$", ErrorMessage = "Phone number must start with 011, 012, 010, or 015 and be exactly 11 digits.")]
		[StringLength(11, ErrorMessage = "Phone number must be exactly 11 digits.", MinimumLength = 11)]
	public string PhoneNumber { get; set; }
		[Required]
        [Compare("Password",ErrorMessage ="Password Do Not Match Please Check Again")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } 

       
    }
}
