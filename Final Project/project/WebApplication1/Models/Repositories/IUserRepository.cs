using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models.Repositories
{
    public interface IUserRepository
    {
        Task<List<Book>> GetBookmarkedBooks(string userId, BookmarkStatus status);
        Task<bool> IsBookmarkedBook(string userId, int bookId);
        Task BookmarkBook(string userId, int bookId);
        Task SetBookmarkStatus(string userId, int bookId, BookmarkStatus status);
        Task UnBookmarkBook(string userId, int bookId);

        Task<List<Chapter>> GetReadChapters(string userId);
        Task<bool> IsReadChapter(string userId, int chapterId);

        Task ReadChapter(string userId, Chapter chapter);
    }
}
