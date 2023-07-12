namespace WebApplication1.Models.Entities
{
    public class Review
    {
        public int ID { get; set; } 
        public int Rating { get; set; } 
        public string Text { get; set; }   
        public int Votes { get; set; }  
        public DateTime Date { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }  
        public string UserID { get; set; } 
        public virtual User User { get; set; }
        public virtual ICollection<UserReview> Voters { get; set; } = new List<UserReview>();
    }
}
