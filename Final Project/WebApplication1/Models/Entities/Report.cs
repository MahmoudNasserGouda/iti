namespace WebApplication1.Models.Entities
{
    public class Report
    {
        public int ID { get; set; } 
        public int BetaSubscriptionMembers { get; set; } 
        public int AlphaSubscriptionMembers { get; set; }
        public int OmegaSubscriptionMembers { get; set; } 
        public double BetaSubscriptionMoney { get; set; }
        public double AlphaSubscriptionMoney { get; set; }
        public double OmegaSubscriptionMoney { get; set; }

    }
}
