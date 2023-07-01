using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        BookStoreContext context;
        public CategoryRepository(BookStoreContext _context)
        {

            context = _context;

        }
        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category GetById(int Id)
        {
            return context.Categories.Where(section => section.ID == Id).FirstOrDefault();
        }

    }
}
