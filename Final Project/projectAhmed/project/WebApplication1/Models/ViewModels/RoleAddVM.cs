using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ViewModels
{
    public class RoleAddVM
    {
        [Required]
        public string Name { get; set; }
    }
}
