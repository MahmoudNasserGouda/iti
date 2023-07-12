namespace WebApplication1.Models.Entities
{
    public class UserReview
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public string UserId { get; set; }
        public int Likes { get; set; }
        public User User { get; set; }
        public Review Review { get; set; }
    }
}
