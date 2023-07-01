using Microsoft.EntityFrameworkCore;
using System.Net;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private BookStoreContext _context;

        public CommentRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task AddComment(Comment comment)
        {
            if (comment != null)
            {
                await _context.Comments.AddAsync(comment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int Id)
        {
            Comment comment = await _context.Comments.Where(r => r.ID == Id).FirstOrDefaultAsync();
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public async Task DownVote(int id)
        {
            Comment comment = _context.Comments.Where(c => c.ID == id).FirstOrDefault();
            if (comment != null)
            {
                comment.Votes -= 1;
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Comment>> GetAll(int chapterId)
        {
            return await _context.Comments.Where(c => c.ChapterID == chapterId).Include(c => c.User).OrderByDescending(c => c.Votes).ToListAsync();
        }

        public async Task UpVote(int id)
        {
            Comment comment = _context.Comments.Where(c => c.ID == id).FirstOrDefault();
            if (comment != null)
            {
                comment.Votes += 1;
            }
            await _context.SaveChangesAsync();
        }
    }
}
