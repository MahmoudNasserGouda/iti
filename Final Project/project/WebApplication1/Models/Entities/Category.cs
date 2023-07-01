using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
