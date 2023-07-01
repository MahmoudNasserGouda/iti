using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(p=> p.ID);
            builder.Property(p=> p.Name).IsRequired();
            builder.Property(p=> p.Description).IsRequired();
            builder.Property(p=> p.Price).IsRequired(); 
            builder.Property(p=> p.PublishDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.HasOne(p => p.Category).WithMany("Books");
            builder.Property(p => p.Rating).IsRequired().HasDefaultValue(0).HasAnnotation("MinValue", 0).HasAnnotation("MaxValue", 100);
            builder.Property(p=> p.AuthorName).IsRequired();
            builder.Property(p => p.ImagePath).IsRequired();
            builder.HasMany(p => p.Users).WithMany("Books");
            //builder.Property(p => p.Users).HasAnnotation("InverseProperty", "Books");
            //builder.Property(p => p.OwnerUsers).HasAnnotation("InverseProperty", "OwnedBooks");
            builder.HasMany(p => p.OwnerUsers).WithMany("OwnedBooks");
            builder.HasMany(p => p.Chapters).WithOne().OnDelete(DeleteBehavior.Cascade);


        }
    }
}
