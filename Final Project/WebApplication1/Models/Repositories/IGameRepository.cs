using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IGameRepository
    {
        List<Book> GetAll();
        Book GetById(int Id);
    }
}