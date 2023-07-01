using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public List<Book> GetAll()
        {
            return _context.Books.Include(p=> p.Category).ToList();
        }
        public List<Book> GetHorror()
        {
            return _context.Books.Include(p => p.Category).Where(p=> p.Category.Name=="Horror").ToList();
        }
        public List<Book> GetSciFi()
        {
            return _context.Books.Include(p => p.Category).Where(p => p.Category.Name == "Sci-Fi").ToList();
        }

        public List<Book> GetAdventure()
        {
            return _context.Books.Include(p => p.Category).Where(p => p.Category.Name == "Adventure").ToList();
        }
        public List<Book> GetSearchResult(string searchstring)
        {
            var query = _context.Books
                .Include(p => p.Category)
                .AsQueryable();
            
            var searchKey = searchstring?.Trim().ToLower() ?? "";
            
            if (!searchKey.IsNullOrEmpty())
            {
               
                var pattern = $"%{searchKey}%"; 
                query = query.Where(i => EF.Functions.Like(i.AuthorName, pattern) ||
                EF.Functions.Like(i.Name, pattern) ||
                EF.Functions.Like(i.Category.Name, pattern) ||
                EF.Functions.Like(i.Description, pattern));
            }

            return query.ToList();
        }

        public Book GetById(int Id)
        {
            return _context.Books.FirstOrDefault(book => book.ID == Id);
        }
    }
}
