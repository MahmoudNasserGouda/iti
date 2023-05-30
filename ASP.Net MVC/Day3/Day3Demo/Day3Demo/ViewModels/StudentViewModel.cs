using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day3Demo.ViewModels
{
    public class StudentViewModel
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        //[Display(Name ="City ID")]
        public string City { get; set; }

        public bool Graduated { get; set; }

        public decimal GPA { get; set; }
    }
}