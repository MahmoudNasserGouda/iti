using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;

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
            UserBook userBook = new UserBook() 
            {
                User = user,
                UserId = userId,
                BookId = bookId,
                Book = book,
                Status = BookmarkStatus.NotStarted
            };
            await _context.UserBooks.AddAsync(userBook);
            await _context.SaveChangesAsync();  
        }

        public async Task<List<Book>> GetBookmarkedBooks(string userId, BookmarkStatus status)
        {
            return await _context.UserBooks.Where(u => u.UserId.Equals(userId) & u.Status == status).Select(u => u.Book).ToListAsync();
        }

        public async Task<List<Chapter>> GetReadChapters(string userId)
        {
            User user = await _context.Users.Include(u => u.ReadChapters).Where(u => u.Id.Equals(userId)).FirstAsync();
            return user.ReadChapters.ToList();
        }

        public async Task<bool> IsBookmarkedBook(string userId, int bookId)
        {
            List<Book> bookmarkedBooks = await _context.UserBooks.Where(u => u.UserId.Equals(userId)).Select(u => u.Book).ToListAsync();
            return bookmarkedBooks.Exists(b => b.ID == bookId);
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

        public async Task SetBookmarkStatus(string userId, int bookId, BookmarkStatus status)
        {
            UserBook userBook = await _context.UserBooks.Where(ub => ub.BookId == bookId & ub.UserId.Equals(userId)).FirstAsync();
            userBook.Status = status;
            await _context.SaveChangesAsync();
        }

        public async Task UnBookmarkBook(string userId, int bookId)
        {
            UserBook userBook = await _context.UserBooks.Where(ub => ub.BookId == bookId & ub.UserId.Equals(userId)).FirstAsync();
            _context.UserBooks.Remove(userBook);
            await _context.SaveChangesAsync();
        }
    }
}
