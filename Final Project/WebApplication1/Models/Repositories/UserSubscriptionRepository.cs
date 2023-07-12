using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models.Repositories
{
    public class UserSubscriptionRepository : IUserSubscriptionRepository
    {
        private readonly BookStoreContext _context;

        public UserSubscriptionRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task AddUserSubscriptionAsync(UserSubscription subscription)
        {
            _context.Add(subscription);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserSubscription>> GetAllUserSubscriptions()
        {
            return await _context.UserSubscriptions
                .Where(i => i.Status != SubscriptionStatus.Expired)
                .ToListAsync();
        }

        public async Task<UserSubscription> GetUserSubscriptionById(int id)
        {
            var subscription = await _context.UserSubscriptions.FirstOrDefaultAsync(x => x.Id == id);
            return subscription;
        }

        public async Task UpdateUserSubscriptionRangeAsync(List<UserSubscription> subscriptions)
        {
            _context.UpdateRange(subscriptions);
            await _context.SaveChangesAsync();
        }
    }
}
