using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class School
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Department Department { get; set; }

        [InverseProperty("FromSchool")]
        public ICollection<TeacherTransfere> TeachersFrom { get; set; }

        [InverseProperty("ToSchool")]
        public ICollection<TeacherTransfere> TeachersTo { get; set; }

    }
}
