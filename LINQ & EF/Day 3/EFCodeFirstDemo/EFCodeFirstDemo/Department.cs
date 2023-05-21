using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    //[Table("MyDept",Schema="MySchema")]
    internal class Department
    {
        //[Key]
        public int ID { get; set; }

       // [Column("DeptName")]
        public string Name { get; set; }

       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Count { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
