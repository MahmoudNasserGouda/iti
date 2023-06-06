using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC6EFDemo.Models
{
    public class CourseBuddy
    {
        [Range(10,100)]
        [Required]
        public int? CrsDuration { get; set; }
    }
}
