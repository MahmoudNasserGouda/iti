using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Content).IsRequired();
            builder.HasOne(p => p.Book).WithMany("Chapters").OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.Users).WithMany("ReadChapters");
            builder.HasMany(p => p.Comments).WithOne().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
