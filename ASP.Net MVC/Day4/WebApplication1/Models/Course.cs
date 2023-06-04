namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Crs_Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Crs_Name { get; set; }

        [Required]
        public int? Crs_Duration { get; set; }

        public int? Ins_Id { get; set; }

        public int? Top_Id { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
