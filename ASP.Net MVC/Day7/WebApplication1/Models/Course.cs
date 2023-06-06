using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public partial class Course
    {
        [Key]
        public int CrsId { get; set; }
        [Required]
        public string? CrsName { get; set; }
        [Required]
        public int? CrsDuration { get; set; }
    }
}
