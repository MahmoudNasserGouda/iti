using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int Id);
    }
}