using AnvuEcommerce.Promotions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnvuEcommerce.Configurations.Promotions
{
    public class PromotionUsageHistoryConfiguration : IEntityTypeConfiguration<PromotionUsageHistory>
    {
        public void Configure(EntityTypeBuilder<PromotionUsageHistory> builder)
        {
            builder.ToTable(AnvuEcommerceConsts.DbTablePrefix + "PromotionUsageHistories");
            builder.HasKey(x => x.Id);
        }
    }
}
