namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dependent")]
    public partial class Dependent
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ESSN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Dependent_name { get; set; }

        [StringLength(50)]
        public string Sex { get; set; }

        public DateTime? Bdate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
