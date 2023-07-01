using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasMany(p=> p.Comments).WithOne("User").HasForeignKey(p=> p.UserID).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Reviews).WithOne("User").HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<User>(){ new User() { Id = "1", PasswordHash="1245",UserName="Mahmoud",Email="Mahmoud@gmail.com",NormalizedEmail="MAHMOUD@GMAIL.COM",NormalizedUserName="MAHMOUD"}  });
        }
    }
}
