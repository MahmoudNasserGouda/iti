using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Chapter> ReadChapters { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Book> OwnedBooks { get; set; }
    }
}
