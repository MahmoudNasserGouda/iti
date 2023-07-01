using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace APICoreProvider.Models
{
    public class ITIEntity :DbContext
    {
        public ITIEntity():base()
        {

        }
        public ITIEntity(DbContextOptions options):base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }


    }
}
