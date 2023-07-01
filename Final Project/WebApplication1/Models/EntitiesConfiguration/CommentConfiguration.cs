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
            builder.HasOne(p => p.Chapter).WithMany("Comments").OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.Users).WithMany("Comments");
        }
    }
}
