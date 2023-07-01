using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class UserCommentConfiguration : IEntityTypeConfiguration<UserComment>
    {
        public void Configure(EntityTypeBuilder<UserComment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(b => b.CommentId);
            builder.HasIndex(b => b.UserId);
            builder.Property(b => b.UserId).IsRequired();
            builder.Property(b => b.CommentId).IsRequired();
            builder.Property(b => b.Likes).IsRequired().HasDefaultValue(0).HasAnnotation("MinValue", -1).HasAnnotation("MaxValue", 1);
            builder.HasOne(b => b.User).WithMany(b => b.LikedComments).HasForeignKey(b => b.UserId);
            builder.HasOne(b => b.Comment).WithMany(b => b.Voters).HasForeignKey(b => b.CommentId);
        }
    }
}
