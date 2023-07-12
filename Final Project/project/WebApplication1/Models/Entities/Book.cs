using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entities
{
    public class Book
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }  
        public int Rating { get; set; } 
        public string PublishDate { get; set; }   
        public string ImagePath { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();    
        public virtual ICollection<UserBook> Users { get; set; } = new List<UserBook>();

    }
}
