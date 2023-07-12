using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasMany(p=> p.Comments).WithOne(p => p.User).HasForeignKey(p=> p.UserID).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Reviews).WithOne(p => p.User).HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.LikedReviews).WithOne(p => p.User).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.LikedComments).WithOne(p => p.User).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.ReadChapters).WithMany(p => p.Users);
            builder.HasMany(p => p.Books).WithOne(p => p.User).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(new List<User>(){
                new User() { 
                    Id = "1",
                    UserName="Mahmoud",
                    Email="Mahmoud@gmail.com",
                    NormalizedEmail="MAHMOUD@GMAIL.COM",
                    NormalizedUserName="MAHMOUD",
                    PasswordHash = "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg==" 
                },
                new User() {
                    Id = "2",
                    UserName="Ahmed",
                    Email="Ahmed@gmail.com",
                    NormalizedEmail="AHMED@GMAIL.COM",
                    NormalizedUserName="AHMED",
                    PasswordHash = "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg=="
                },
                new User() {
                    Id = "3",
                    UserName="Abdullah",
                    Email="Abdullah@gmail.com",
                    NormalizedEmail="ABDULLAH@GMAIL.COM",
                    NormalizedUserName="ABDULLAH",
                    PasswordHash = "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg=="
                },
                new User() {
                    Id = "4",
                    UserName="mohamed",
                    Email="mohamed@gmail.com",
                    NormalizedEmail="MOHAMED@GMAIL.COM",
                    NormalizedUserName="MOHAMED",
                    PasswordHash = "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg=="
                }
            });
        }
    }
}
