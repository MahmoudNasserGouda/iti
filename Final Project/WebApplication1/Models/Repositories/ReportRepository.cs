using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public class ReportRepository:IReportRepository
    {
        BookStoreContext _context;
        public ReportRepository(BookStoreContext context)
        {

            _context = context;

        }
        public async Task<Report> ReturnReport()
        {
            return _context.Reports.FirstOrDefault();
        }
        public async Task<int> GetBetaSubsMembers()
        {
            return _context.Reports.Select(i=> i.BetaSubscriptionMembers).FirstOrDefault();
        }
        public async Task<int> AddBetaSubMember(int member)
        {
          var number = _context.Reports.Select(i => i.BetaSubscriptionMembers).FirstOrDefault();
            number = number + member;
            _context.Update(number); 
            _context.SaveChanges();
            return 1 ;
        }
        public async Task<double> CalcBetaSubMoney()
        {
            var members = _context.Reports.Select(i => i.BetaSubscriptionMembers).FirstOrDefault();
            var total = members * 59.99;
            return total;
        }
        public async Task<int> GetAlphaSubsMembers()
        {
            return _context.Reports.Select(i => i.AlphaSubscriptionMembers).FirstOrDefault();
        }
        public async Task<int> AddAlphaSubMember(int member)
        {
            var number = _context.Reports.Select(i => i.AlphaSubscriptionMembers).FirstOrDefault();
            number = number + member;
            _context.SaveChanges();
            return 1;
        }
        public async Task<double> CalcAlphaSubMoney()
        {
            var members = _context.Reports.Select(i => i.BetaSubscriptionMembers).FirstOrDefault();
            var total = members * 79.99;
            return total;
        }
        public async Task<int> GetOmegaSubsMembers()
        {
            return _context.Reports.Select(i => i.OmegaSubscriptionMembers).FirstOrDefault();
        }
        public async Task<int> AddOmegaSubMember(int member)
        {
            var number = _context.Reports.Select(i => i.OmegaSubscriptionMembers).FirstOrDefault();
            number = number + member;
            _context.SaveChanges();
            return 1;
        }
        public async Task<double> CalcOmegaSubMoney()
        {
            var members = _context.Reports.Select(i => i.BetaSubscriptionMembers).FirstOrDefault();
            var total = members * 99.99;
            return total;
        }

    }
}
