using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class DepartmentConfiguration :EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            this.ToTable("Dept");
            //this.Property(d => d.Count).IsOptional();
        }
    }
}
