using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        BookStoreContext _context;
        public CategoryRepository(BookStoreContext context)
        {

            _context = context;

        }
        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int Id)
        {
            return await _context.Categories.Where(section => section.ID == Id).FirstOrDefaultAsync();
        }

    }
}
