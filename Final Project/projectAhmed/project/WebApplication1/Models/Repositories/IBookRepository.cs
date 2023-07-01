using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int Id);
        public List<Book> GetHorror();
        public List<Book> GetSciFi();
        public List<Book> GetAdventure();
        public List<Book> GetSearchResult(string searchstring);
    }
}