using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MVC6EFDemo.Models
{
    //[MetadataType(typeof(CourseBuddy))]
    public partial class Course
    {
        public Course()
        {
            StudCourses = new HashSet<StudCourse>();
        }

        public int CrsId { get; set; }
        public string CrsName { get; set; }

        [Range(10, 100)]
        [Required]
        public int? CrsDuration { get; set; }
        public int? InsId { get; set; }
        public int? TopId { get; set; }

        public virtual Instructor Ins { get; set; }
        public virtual Topic Top { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
