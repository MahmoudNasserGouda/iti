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
            builder.Property(p => p.Rating).IsRequired().HasDefaultValue(0).HasAnnotation("MinValue", 0).HasAnnotation("MaxValue", 5);
            builder.HasOne(p => p.Book).WithMany("Reviews").HasForeignKey(p=> p.BookID).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.User).WithMany("Reviews").HasForeignKey(p => p.UserID).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(new List<Review>() { new Review() { ID = 1, Text = "Very amusing book", BookID = 1, Rating = 3, Votes = 10, Date = DateTime.Now, UserID= "1" }, new Review() { ID = 2, Text = "Very creative writing", BookID = 1, Rating = 4, Votes = 5, Date = DateTime.Now, UserID= "1" } });
        }
    }
}
