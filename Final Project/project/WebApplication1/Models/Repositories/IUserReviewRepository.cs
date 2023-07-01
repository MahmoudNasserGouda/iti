using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IUserReviewRepository
    {
        Task<UserReview> GetUserReviewAsync(string userId, int reviewId);
        Task SetUserReviewAsync(string userId, int reviewId, int likes);
    }
}
