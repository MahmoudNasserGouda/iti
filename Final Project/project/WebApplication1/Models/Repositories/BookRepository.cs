using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Models.Entities;


namespace WebApplication1.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookStoreContext _context;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task CalculateRating(int Id)
        {
            List<Review> reviews = await _context.Reviews.Where(c => c.BookID == Id).ToListAsync();
            int rating = 0;
            foreach (Review review in reviews)
            {
                rating += review.Rating;
            }
            if (reviews.Count != 0)
            {
                rating = (rating * 100) / (reviews.Count * 5);
            }
            else
            {
                rating = 0;
            }

            Book book = await _context.Books.Where(b => b.ID == Id).FirstOrDefaultAsync();
            if (book != null)
            {
                book.Rating = rating;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.Include(b => b.Category).ToListAsync();
        }

        public async Task<Book> GetById(int Id)
        {
            return await _context.Books.Include(b => b.Category).Where(book => book.ID == Id).FirstOrDefaultAsync();
        }

        public async Task<int> GetReviewsCount(int Id)
        {
            return await _context.Books.Where(b => b.ID == Id).Select(b => b.Reviews.Count()).FirstOrDefaultAsync();
        }

        public List<Book> GetHorror()
        {
            return _context.Books.Include(p => p.Category).Where(p => p.Category.Name == "Horror").ToList();
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

            if (!String.IsNullOrEmpty(searchKey))
            {
                var pattern = $"%{searchKey}%";
                query = query.Where(i => EF.Functions.Like(i.AuthorName, pattern) ||
                EF.Functions.Like(i.Name, pattern) ||
                EF.Functions.Like(i.Category.Name, pattern) ||
                EF.Functions.Like(i.Description, pattern));
            }

            return query.ToList();
        }
    }
}
