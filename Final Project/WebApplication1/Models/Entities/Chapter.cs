namespace WebApplication1.Models.Entities
{
    public class Chapter
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } 
        //public int BookID { get; set; }        
        public virtual Book Book { get; set; }
        public virtual ICollection<Comment> Comments { get; set;}
        public virtual ICollection<User> Users { get; set; }

    }
}
