using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class UserReviewConfiguration : IEntityTypeConfiguration<UserReview>
    {
        public void Configure(EntityTypeBuilder<UserReview> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(b => b.ReviewId);
            builder.HasIndex(b => b.UserId);
            builder.Property(b => b.UserId).IsRequired();
            builder.Property(b => b.ReviewId).IsRequired();
            builder.Property(b => b.Likes).IsRequired().HasDefaultValue(0).HasAnnotation("MinValue", -1).HasAnnotation("MaxValue", 1);
            builder.HasOne(b => b.User).WithMany(b => b.LikedReviews).HasForeignKey(b => b.UserId);
            builder.HasOne(b => b.Review).WithMany(b => b.Voters).HasForeignKey(b => b.ReviewId);
        }
    }
}
