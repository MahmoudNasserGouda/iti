using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.EntitiesConfiguration
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasData(
      new Report
      {
          ID=1,
          BetaSubscriptionMembers = 30,
          AlphaSubscriptionMembers = 40,
          OmegaSubscriptionMembers = 50,
          BetaSubscriptionMoney = 30*59.99,
          AlphaSubscriptionMoney = 40*79.99,
          OmegaSubscriptionMoney = 50 * 99.99
      }
  );

        }
    }
}
