using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new List<IdentityUserRole<string>>(){
                new IdentityUserRole<string>()
                {
                    RoleId = "1",
                    UserId = "1",
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "2",
                    UserId = "1",
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "1",
                    UserId = "2",
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "2",
                    UserId = "3",
                }
            });
        }
    }
}
