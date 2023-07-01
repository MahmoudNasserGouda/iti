using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface ISectionRepository
    {
        List<Category> GetAll();
        Category GetById(int Id);
    }
}