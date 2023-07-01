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
            builder.HasOne(p => p.Book).WithMany("Reviews").OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.User).WithMany("Reviews");
        }
    }
}
