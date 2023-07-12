using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IUserCommentRepository
    {
        Task<UserComment> GetUserCommentAsync(string userId, int commentId);
        Task SetUserCommentAsync(string userId, int commentId, int likes);
    }
}
