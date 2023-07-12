using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> TopFiveRatedBooks();
        Task<List<Book>> GetAll();
        Task<Book> GetById(int Id);
        Task<int> GetReviewsCount(int Id);
        Task CalculateRating(int Id);
        Task<List<Book>> GetByCategory(int categoryId);
		//List<Book> GetHorror();
		//List<Book> GetSciFi();
		//List<Book> GetAdventure();
		Task<List<Book>> GetSearchResult(int categoryId, string searchstring);
        Task UpdateBook(int ID, Book bookUpdated);
        Task SaveBook(Book bookSaved);
        Task DeleteBook(int ID);
    }
}