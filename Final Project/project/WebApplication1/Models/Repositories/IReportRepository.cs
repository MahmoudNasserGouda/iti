using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IReportRepository
    {
        Task<Report> ReturnReport();
        Task<int> AddBetaSubMember(int member);
        Task<int> GetBetaSubsMembers();
        Task<double> CalcBetaSubMoney();
        Task<int> AddAlphaSubMember(int member);
        Task<int> GetAlphaSubsMembers();
        Task<double> CalcAlphaSubMoney();
        Task<int> AddOmegaSubMember(int member);
        Task<int> GetOmegaSubsMembers();
        Task<double> CalcOmegaSubMoney();

    }
}