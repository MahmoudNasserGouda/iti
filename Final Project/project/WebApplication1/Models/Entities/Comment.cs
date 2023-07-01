namespace WebApplication1.Models.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int Votes { get; set; }
        public DateTime Date { get; set; }
        public int ChapterID { get; set; }
        public virtual Chapter Chapter { get; set; }
        public string UserID { get; set; }
        public virtual User User { get; set;}
        public virtual ICollection<UserComment> Voters { get; set; } = new List<UserComment>();
    }
}
