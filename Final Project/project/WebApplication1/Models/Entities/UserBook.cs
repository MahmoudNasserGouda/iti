using WebApplication1.Models.Enums;

namespace WebApplication1.Models.Entities
{
    public class UserBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public BookmarkStatus Status { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
