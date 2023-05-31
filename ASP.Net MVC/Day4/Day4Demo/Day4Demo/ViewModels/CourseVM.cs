using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day4Demo.ViewModels
{
    public class CourseVM
    {
        [Display(Name ="Course ID")]
        public int Crs_Id { get; set; }
        [Display(Name = "Course Name")]
        public string Crs_Name { get; set; }
        [Display(Name = "Course Duration")]
        public int? Crs_Duration { get; set; }
        [Display(Name = "Instructor Name")]
        public string Inst_Name { get; set; }
        [Display(Name = "Topic Name")]
        public string Topic_Name { get; set; }

    }
}