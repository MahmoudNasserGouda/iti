namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierPhone")]
    public partial class SupplierPhone
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string Phone { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
