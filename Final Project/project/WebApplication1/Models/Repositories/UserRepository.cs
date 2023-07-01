using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BookStoreContext _context;

        public UserRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task BookmarkBook(string userId, int bookId)
        {
            Book book = await _context.Books.Where(b => b.ID == bookId).FirstAsync();
            User user = await _context.Users.Where(u => u.Id.Equals(userId)).FirstAsync();
            user.Books.Add(book);
            await _context.SaveChangesAsync();  
        }

        public async Task<List<Book>> GetBookmarkedBooks(string userId)
        {
            User user = await _context.Users.Include(u => u.Books).Where(u => u.Id.Equals(userId)).FirstAsync();
            return user.Books.ToList();
        }

        public async Task<List<Book>> GetOwnedBooks(string userId)
        {
            User user = await _context.Users.Include(u => u.OwnedBooks).Where(u => u.Id.Equals(userId)).FirstAsync();
            return  user.OwnedBooks.ToList();
        }

        public async Task<List<Chapter>> GetReadChapters(string userId)
        {
            User user = await _context.Users.Include(u => u.ReadChapters).Where(u => u.Id.Equals(userId)).FirstAsync();
            return user.ReadChapters.ToList();
        }

        public async Task<bool> IsBookmarkedBook(string userId, int bookId)
        {
            List<Book> bookmarkedBooks = await GetBookmarkedBooks(userId);
            return bookmarkedBooks.Exists(b => b.ID == bookId);
        }

        public async Task<bool> IsOwnedBook(string userId, int bookId)
        {
            List<Book> ownedBooks = await GetOwnedBooks(userId);
            return ownedBooks.Exists(b => b.ID == bookId);
        }

        public async Task<bool> IsReadChapter(string userId, int chapterId)
        {
            List<Chapter> readChapters = await GetReadChapters(userId);
            return readChapters.Exists(b => b.ID == chapterId);
        }

        public async Task ReadChapter(string userId, Chapter chapter)
        {
            User user = await _context.Users.Include(u => u.ReadChapters).Where(u => u.Id.Equals(userId)).FirstAsync();
            user.ReadChapters.Add(chapter);
            await _context.SaveChangesAsync();
        }

        public async Task UnBookmarkBook(string userId, int bookId)
        {
            Book book = await _context.Books.Where(b => b.ID == bookId).FirstAsync();
            User user = await _context.Users.Include(u => u.Books).Where(u => u.Id.Equals(userId)).FirstAsync();
            user.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
