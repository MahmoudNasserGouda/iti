using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int Id);
    }
}