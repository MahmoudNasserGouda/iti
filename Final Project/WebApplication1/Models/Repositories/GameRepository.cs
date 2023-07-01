using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class GameRepository : IGameRepository
    {
        BookStoreContext context;
        public GameRepository(BookStoreContext _context)
        {
            context = _context;
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }
        public Book GetById(int Id)
        {
            return context.Books.Where(book => book.ID == Id).FirstOrDefault();
        }




    }
}
