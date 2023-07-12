using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private BookStoreContext _context;

        public ReviewRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task AddReview(Review review)
        {
            if (review != null)
            {
                await _context.Reviews.AddAsync(review);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int Id)
        {
            Review review = await _context.Reviews.Where(r => r.ID == Id).FirstOrDefaultAsync();
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
        }

        public async Task DownVote(int id)
        {
            Review review = _context.Reviews.Where(c => c.ID == id).FirstOrDefault();
            if (review != null)
            {
                review.Votes -= 1;
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Review>> GetAll(int bookId)
        {
            return await _context.Reviews.Where(c => c.BookID == bookId).Include(c => c.User).OrderByDescending(c => c.Votes).ToListAsync();
        }

        public async Task<Review> GetById(int Id)
        {
            return await _context.Reviews.Where(c => c.ID == Id).Include(c => c.User).FirstOrDefaultAsync();
        }

        public async Task UpVote(int id)
        {
            Review review = _context.Reviews.Where(c => c.ID == id).FirstOrDefault();
            if (review != null)
            {
                review.Votes += 1;
            }
            await _context.SaveChangesAsync();
        }
    }
}
