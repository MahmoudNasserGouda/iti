using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IUserRepository
    {
        Task<List<Book>> GetOwnedBooks(string userId);
        Task<bool> IsOwnedBook(string userId, int bookId);

        Task<List<Book>> GetBookmarkedBooks(string userId);
        Task<bool> IsBookmarkedBook(string userId, int bookId);
        Task BookmarkBook(string userId, int bookId);
        Task UnBookmarkBook(string userId, int bookId);

        Task<List<Chapter>> GetReadChapters(string userId);
        Task<bool> IsReadChapter(string userId, int chapterId);

        Task ReadChapter(string userId, Chapter chapter);
    }
}
