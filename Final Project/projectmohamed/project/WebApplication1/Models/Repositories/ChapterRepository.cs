using Microsoft.EntityFrameworkCore;
using System.Net;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class ChapterRepository : IChapterRepository
    {

        private BookStoreContext _context;

        public ChapterRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<List<Chapter>> GetAll(int bookId)
        {
           // return await _context.Chapters.Where(c => c.BookID == bookId).OrderBy(c => c.Order).ToListAsync();
            return await _context.Chapters.Where(c => c.BookID == bookId).OrderBy(c => c.BookID).ToListAsync();
        }


        public async Task<Chapter> GetById(int Id)
        {
            return await _context.Chapters.Where(c => c.ID == Id).FirstOrDefaultAsync();
        }
    }
}
