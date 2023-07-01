using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int Id);
    }
}