using AnvuEcommerce.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnvuEcommerce.Configurations.Products
{
    public class ProductLinkConfiguration : IEntityTypeConfiguration<ProductLink>
    {
        public void Configure(EntityTypeBuilder<ProductLink> builder)
        {
            builder.ToTable(AnvuEcommerceConsts.DbTablePrefix + "ProductLinks");
            builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
        }
    }
}
