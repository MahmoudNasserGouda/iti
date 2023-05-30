using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3Demo.Models
{
    public partial class StudentBuddyClass
    {
        //[HiddenInput(DisplayValue = false)]
        //public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Full Name")]
        //[DataType(DataType.EmailAddress)]
        public string FullName { get; set; }

        [Display(Name = "City ID")]
        public int CityID { get; set; }

        [Range(minimum:1.0, maximum:4.0)]
        public decimal GPA { get; set; }

    }
}