using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Text).IsRequired();
            builder.Property(p => p.Date).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(p => p.Votes).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.Rating).IsRequired().HasDefaultValue(1).HasAnnotation("MinValue", 1).HasAnnotation("MaxValue", 5);
            builder.HasOne(p => p.Book).WithMany(p => p.Reviews).HasForeignKey(p=> p.BookID);
            builder.HasMany(p => p.Voters).WithOne(p => p.Review).HasForeignKey(p => p.ReviewId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.User).WithMany(p => p.Reviews).HasForeignKey(p => p.UserID);
            builder.HasData(new List<Review>() { 
                new Review() { 
                    ID = 1, 
                    Text = "Very amusing book", 
                    BookID = 1, 
                    Rating = 3, 
                    Votes = 10, 
                    Date = DateTime.Now, 
                    UserID= "1" 
                }, 
                new Review() { 
                    ID = 2, 
                    Text = "Very creative writing", 
                    BookID = 1, 
                    Rating = 4, 
                    Votes = 5, 
                    Date = DateTime.Now, 
                    UserID= "1" 
                } 
            });
        }
    }
}
