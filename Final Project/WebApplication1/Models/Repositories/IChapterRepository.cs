using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IChapterRepository
    {
        Task<List<Chapter>> GetAll(int bookID);
        Task<Chapter> GetById(int Id);
        Task Delete(int Id);
        Task Up(int Id);
        Task Down(int Id);
        Task AddChapter(Chapter chapter);
        Task EditChapter(int Id, Chapter chapter);
    }
}
