using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAll();
        Task<Book> GetById(int Id);
        Task<int> GetReviewsCount(int Id);
        Task CalculateRating(int Id);
        public List<Book> GetHorror();
        public List<Book> GetSciFi();
        public List<Book> GetAdventure();
        public List<Book> GetSearchResult(string searchstring);
    }
}