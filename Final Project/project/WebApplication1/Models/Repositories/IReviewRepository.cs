using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetAll(int bookID);
        Task<Review> GetById(int Id);
        Task AddReview(Review review);
        Task Delete(int Id);
        Task UpVote(int id);
        Task DownVote(int id);
    }
}
