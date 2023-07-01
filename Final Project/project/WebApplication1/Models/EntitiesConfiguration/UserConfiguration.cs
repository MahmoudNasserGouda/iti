using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

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
            builder.HasMany(p => p.OwnedBooks).WithMany(p => p.OwnerUsers);
            builder.HasMany(p => p.ReadChapters).WithMany(p => p.Users);
            builder.HasMany(p => p.Books).WithMany(p => p.Users);
            builder.HasData(new List<User>(){
                new User() { 
                    Id = "1",
                    UserName="Mahmoud",
                    Email="Mahmoud@gmail.com",
                    NormalizedEmail="MAHMOUD@GMAIL.COM",
                    NormalizedUserName="MAHMOUD",
                    PasswordHash = "AQAAAAIAAYagAAAAEM6bztfW4lSrkXqVBXPaXhBGUIAznEuiidOvk5ojWngU0HnGQVxaZOPVaZGMdzhvIg==" 
                }  
            });
        }
    }
}
