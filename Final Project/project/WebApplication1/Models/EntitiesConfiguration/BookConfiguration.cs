using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).UseIdentityColumn(1,1);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.PublishDate).IsRequired();
            builder.Property(p => p.Rating).IsRequired().HasDefaultValue(0).HasAnnotation("MinValue", 0).HasAnnotation("MaxValue", 100);
            builder.Property(p => p.AuthorName).IsRequired();
            builder.Property(p => p.ImagePath).IsRequired();
            builder.HasOne(p => p.Category).WithMany(p => p.Books).HasForeignKey(p => p.CategoryId);
            builder.HasMany(p => p.Users).WithMany(p => p.Books);
            builder.HasMany(p => p.OwnerUsers).WithMany(p => p.OwnedBooks);
            builder.HasMany(p => p.Chapters).WithOne(p => p.Book).HasForeignKey(p => p.BookID).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Reviews).WithOne(p => p.Book).HasForeignKey(p => p.BookID).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Book>() { 
                new Book(){
                    ID=1,
                    Name= "The Call of Cthulhu",
                    Description= "The Call of Cthulhu is a short story by American writer H. P. Lovecraft. Written in the summer of 1926, it was first published in the pulp magazine Weird Tales in February 1928.",
                    AuthorName= "H. P. Lovecraft",
                    Rating=70,
                    PublishDate= "1928",
                    ImagePath= "https://m.media-amazon.com/images/I/515TltJSPEL.jpg", 
                    Price= 19.99, 
                    CategoryId=1 
                },
                new Book(){
                    ID=2, 
                    Name = "The Monkey's Paw", 
                    Description = "The Monkey's Paw is a short story by English writer W.W. Jacobs. It was first published in Harper's Monthly magazine in 1902. The story follows the White family, who come into possession of a magical monkey's paw that grants three wishes.",
                    AuthorName = "W.W. Jacobs",
                    Rating = 0,
                    PublishDate = "1902", 
                    Price = 9.99, 
                    ImagePath="https://m.media-amazon.com/images/I/51e7aoodRtL.jpg", 
                    CategoryId=1
                }, 
                new Book(){
                    ID=3,
                    Name = "The Tell-Tale Heart",
                    Description = "The Tell-Tale Heart is a short story by American writer Edgar Allan Poe. It was first published in 1843. The story is narrated by an unnamed protagonist who is obsessed with the eye of an elderly man. As his obsession grows, he commits a heinous act of murder.",
                    AuthorName = "Edgar Allan Poe",
                    Rating = 0,
                    PublishDate = "1843",
                    Price = 14.99, 
                    CategoryId=1, 
                    ImagePath="https://m.media-amazon.com/images/I/71igzz1F+JL._AC_UF1000,1000_QL80_.jpg"
                }, 
                new Book(){
                    ID=4,
                    Name = "Carmilla", 
                    Description = "Carmilla is a Gothic novella by Irish writer J. Sheridan Le Fanu. It was first published in 1872. The story revolves around a young woman named Laura, who becomes friends with the mysterious and alluring Carmilla. As their relationship deepens, Laura begins to suspect that Carmilla may be a supernatural entity.",
                    AuthorName = "J. Sheridan Le Fanu",
                    Rating = 0,
                    PublishDate = "1872",
                    Price = 12.99, 
                    CategoryId=1, 
                    ImagePath="https://images.penguinrandomhouse.com/cover/9781782275848"
                },
                new Book(){
                    ID=5,
                    Name = "The Yellow Wallpaper",
                    Description = "The Yellow Wallpaper is a haunting short story by American writer Charlotte Perkins Gilman. It was first published in 1892. The story is narrated by a woman who is confined to a room with yellow wallpaper. As her mental state deteriorates, she becomes obsessed with the wallpaper, leading to a descent into madness.",
                    AuthorName = "Charlotte Perkins Gilman",
                    Rating = 0,
                    PublishDate = "1892",
                    Price = 11.99, 
                    CategoryId=1, 
                    ImagePath="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSpjWuHwCM_LBBK08M-ZsGGZ6hOm6pBxrngYEzRTTJ&s"
                } 
            });




        }
    }
}
