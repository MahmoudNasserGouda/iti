namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public class Product
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public int SupplierID { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
