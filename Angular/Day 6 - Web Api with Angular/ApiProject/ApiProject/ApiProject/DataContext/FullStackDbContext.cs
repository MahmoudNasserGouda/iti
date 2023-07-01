using ApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.DataContext
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
