using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class UserCommentRepository : IUserCommentRepository
    {
        private BookStoreContext _context;

        public UserCommentRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<UserComment> GetUserCommentAsync(string userId, int commentId)
        {
            UserComment userComment = await _context.UserComments.Where(c => c.UserId.Equals(userId) && c.CommentId == commentId).FirstOrDefaultAsync();
            return userComment;
        }

        public async Task SetUserCommentAsync(string userId, int commentId, int likes)
        {
            UserComment userComment = await GetUserCommentAsync(userId, commentId);
            if (userComment == null)
            {
                userComment = new UserComment()
                {
                    CommentId = commentId,
                    UserId = userId,
                    Likes = likes,
                };
                await _context.UserComments.AddAsync(userComment);
            }
            else
            {
                userComment.Likes = likes;
            }
            await _context.SaveChangesAsync();
        }
    }
}
