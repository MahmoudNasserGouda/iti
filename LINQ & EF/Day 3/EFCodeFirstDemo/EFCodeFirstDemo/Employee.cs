using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }


        [ConcurrencyCheck]
        public int Salary { get; set; }

        //[Timestamp]
        //public byte[] TimeStamp { get; set; }

        [NotMapped]
        public int Age { get; set; }

       // [ForeignKey("Department")]
       // public int DepID { get; set; }

        //Many to One
        public Department Department { get; set; }

        //Many to Many
        public List<Project> Projects { get; set; }

        public Address Address { get; set; }

    }
}
