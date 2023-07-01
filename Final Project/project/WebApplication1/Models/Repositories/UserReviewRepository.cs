using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class UserReviewRepository : IUserReviewRepository
    {
        private BookStoreContext _context;

        public UserReviewRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<UserReview> GetUserReviewAsync(string userId, int reviewId)
        {
            UserReview userReview = await _context.UserReviews.Where(c => c.UserId.Equals(userId) && c.ReviewId == reviewId).FirstOrDefaultAsync();
            return userReview;
        }

        public async Task SetUserReviewAsync(string userId, int reviewId, int likes)
        {
            UserReview userReview = await GetUserReviewAsync(userId, reviewId);
            if (userReview == null)
            {
                userReview = new UserReview() 
                { 
                    ReviewId = reviewId,
                    UserId = userId,
                    Likes = likes,
                };
                await _context.UserReviews.AddAsync(userReview);
            }
            else
            {
                userReview.Likes = likes;
            }
            await _context.SaveChangesAsync();
        }
    }
}
