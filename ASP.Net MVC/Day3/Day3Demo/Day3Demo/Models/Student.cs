namespace Day3Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Student")]
    [MetadataType(typeof(StudentBuddyClass))]
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        //[Display(Name ="Full Name")]
        //[DataType(DataType.EmailAddress)]
        public string FullName { get; set; }

        //[Display(Name ="City ID")]
        public int CityID { get; set; }

        public bool Graduated { get; set; }

        public decimal GPA { get; set; }

        public virtual City City { get; set; }
    }
}
