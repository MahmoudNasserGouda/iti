using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.RegularExpressions;
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

        public async Task AddChapter(Chapter chapter)
        {
            chapter.Content = Regex.Unescape(chapter.Content);
            await _context.Chapters.AddAsync(chapter);
            await _context.SaveChangesAsync();
        }

        public async Task Order(int bookId)
        {
            List<Chapter> chapters = await GetAll(bookId);
            for (int i = 0; i < chapters.Count(); i++)
            {
                chapters[i].Order = i + 1;
            }
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int Id)
        {
            Chapter chapter = await GetById(Id);
            _context.Chapters.Remove(chapter);
            await _context.SaveChangesAsync();

            await Order(chapter.BookID);
        }

        public async Task<List<Chapter>> GetAll(int bookId)
        {
            return await _context.Chapters.Where(c => c.BookID == bookId).OrderBy(c => c.Order).ToListAsync();
        }

        public async Task<Chapter> GetById(int Id)
        {
            return await _context.Chapters.Where(c => c.ID == Id).FirstOrDefaultAsync();
        }
    }
}
