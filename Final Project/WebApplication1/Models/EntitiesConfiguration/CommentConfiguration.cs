using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Text).IsRequired();
            builder.Property(p => p.Date).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(p => p.Votes).IsRequired().HasDefaultValue(0);
            builder.HasOne(p => p.Chapter).WithMany(p => p.Comments).HasForeignKey(p=> p.ChapterID);
            builder.HasOne(p => p.User).WithMany(p => p.Comments).HasForeignKey(p => p.UserID);
            builder.HasMany(p => p.Voters).WithOne(p => p.Comment).HasForeignKey(p => p.CommentId).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Comment>() {
                new Comment() { 
                    ID = 1, 
                    Text = "Great chapter, very scary", 
                    Date = DateTime.Now, 
                    Votes = -1, 
                    ChapterID = 1 , 
                    UserID="1"
                },
                new Comment() { 
                    ID = 2, 
                    Text = "Bad Chapter, very scary for me", 
                    Date = DateTime.Now, 
                    Votes = 3, 
                    ChapterID = 1, 
                    UserID="1"
                },
                new Comment() {
                    ID=3, 
                    Text="Not bad",
                    Date=DateTime.Now, 
                    Votes=5,
                    ChapterID=1, 
                    UserID = "1"
                },
                new Comment() {
                    ID=4, 
                    Text="Didn't meet my expectations to be honest",
                    Date=DateTime.Now, 
                    Votes=2,
                    ChapterID=1, 
                    UserID = "1" 
                }
            });
        }
    }
}
