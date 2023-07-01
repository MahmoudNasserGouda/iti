namespace WebApplication1.Models.Entities
{
    public class Chapter
    {
        public int ID { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } 
        public int BookID { get; set; }        
        public virtual Book Book { get; set; }
        public virtual ICollection<Comment> Comments { get; set;} = new List<Comment>();
        public virtual ICollection<User> Users { get; set; } = new List<User>();

    }
}
