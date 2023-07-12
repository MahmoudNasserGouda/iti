using WebApplication1.Models.Enums;

namespace WebApplication1.Models.Entities
{
    public class UserSubscription
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual User User { get; set; }
        public SubscriptionStatus Status { get; set; }
    }
}
