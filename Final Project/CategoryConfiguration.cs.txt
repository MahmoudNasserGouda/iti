using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p=> p.Name).IsRequired();
            builder.HasMany(p => p.Books).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Category>() { 
                new Category() {
                    ID=1, 
                    Name="Horror" 
                },
                new Category()
                {
                    ID=2,
                    Name="Adventure"
				},
                new Category()
                {
                    ID =3,
                    Name="Sci-Fi"
				},
                new Category()
                {
                    ID=4,
                    Name="Romance"
                }
            });
        }
    }
}
