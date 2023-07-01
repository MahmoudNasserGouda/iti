namespace WebApplication1.Models.Entities
{
    public class UserComment
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public string UserId { get; set; }
        public int Likes { get; set; }
        public User User { get; set; }
        public Comment Comment { get; set; }
    }
}
