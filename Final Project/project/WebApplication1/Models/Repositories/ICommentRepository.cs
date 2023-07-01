using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAll(int chapterId);
        Task AddComment(Comment comment);
        Task Delete(int Id);
        Task UpVote(int id);
        Task DownVote(int id);
    }
}
