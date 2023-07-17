using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<UserBook> Books { get; set; } = new List<UserBook>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        public virtual ICollection<Chapter> ReadChapters { get; set; } = new List<Chapter>();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<UserReview> LikedReviews { get; set; } = new List<UserReview>();
        public virtual ICollection<UserComment> LikedComments { get; set; } = new List<UserComment>();
        public virtual UserSubscription Subscription { get; set; }
        public string ResetPasswordToken { get; set; } = "";
        public DateTime? ResetPasswordTokenExpirationDate { get; set; } = null;
        public bool IsResetTokenUsed { get; set; } = false;
    }
}
