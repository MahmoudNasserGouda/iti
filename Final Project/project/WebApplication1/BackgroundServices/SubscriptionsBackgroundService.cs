using Microsoft.AspNetCore.Identity;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;
using WebApplication1.Models.Repositories;

namespace WebApplication1.BackgroundServices
{
    public class SubscriptionsBackgroundService : BackgroundService
    {
        //private readonly IUserSubscriptionRepository _subscriptionRepository;
        //private readonly UserManager<User> _userManager;
        private readonly IServiceScopeFactory _scopeFactory;

        public SubscriptionsBackgroundService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await UpdateSubscriptions();

                // Delay for 24 hours
                await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
            }
        }
        private async Task UpdateSubscriptions()
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                // Fetch all subscriptions and change expired subscriptions to expired, and remove user role
                var subscriptionRepository = scope.ServiceProvider.GetRequiredService<IUserSubscriptionRepository>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                var subscriptions = await subscriptionRepository.GetAllUserSubscriptions();
                var expiredUserIds = new List<string>();
                foreach (var subscription in subscriptions)
                {
                    if (subscription.EndDate <= DateTime.UtcNow)
                    {
                        subscription.Status = SubscriptionStatus.Expired;
                        expiredUserIds.Add(subscription.UserId);
                    }
                }
                await subscriptionRepository.UpdateUserSubscriptionRangeAsync(subscriptions);
                // Update user roles
                var users = userManager.Users
                    .Where(i => expiredUserIds.Contains(i.Id))
                    .ToList();

                foreach (var user in users)
                {
                    await userManager.RemoveFromRoleAsync(user, "Premium");
                }
            }

        }
    }
}
