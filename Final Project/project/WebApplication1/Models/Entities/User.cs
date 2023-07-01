using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models.Entities
{
    public class User:IdentityUser
    {
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
        public virtual ICollection<Review> Reviews { get; set;} = new List<Review>();
        public virtual ICollection<Chapter> ReadChapters { get; set; } = new List<Chapter>();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<Book> OwnedBooks { get; set; } = new List<Book>();
        public virtual ICollection<UserReview> LikedReviews { get; set; } = new List<UserReview>();
        public virtual ICollection<UserComment> LikedComments { get; set; } = new List<UserComment>();
    }
}
