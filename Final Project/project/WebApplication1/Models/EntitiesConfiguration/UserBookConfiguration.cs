using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class UserBookConfiguration : IEntityTypeConfiguration<UserBook>
    {
        public void Configure(EntityTypeBuilder<UserBook> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(b => b.BookId);
            builder.HasIndex(b => b.UserId);
            builder.Property(b => b.UserId).IsRequired();
            builder.Property(b => b.BookId).IsRequired();
            builder.Property(b => b.Status).IsRequired().HasDefaultValue(BookmarkStatus.NotStarted);
            builder.HasOne(b => b.User).WithMany(b => b.Books).HasForeignKey(b => b.UserId);
            builder.HasOne(b => b.Book).WithMany(b => b.Users).HasForeignKey(b => b.BookId);
        }
    }
}
