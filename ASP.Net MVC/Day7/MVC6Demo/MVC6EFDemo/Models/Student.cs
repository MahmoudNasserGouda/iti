using System;
using System.Collections.Generic;

#nullable disable

namespace MVC6EFDemo.Models
{
    public partial class Student
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
    }
}
