using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Repositories
{
    public interface IUserSubscriptionRepository
    {
        Task AddUserSubscriptionAsync(UserSubscription subscription);
        Task UpdateUserSubscriptionRangeAsync(List<UserSubscription> subscriptions);
        Task<List<UserSubscription>> GetAllUserSubscriptions();
        Task<UserSubscription> GetUserSubscriptionById(int id);
    }
}
