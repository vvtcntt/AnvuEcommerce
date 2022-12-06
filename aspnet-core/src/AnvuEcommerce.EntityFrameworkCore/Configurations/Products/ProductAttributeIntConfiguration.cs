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
    public class ProductAttributeIntConfiguration : IEntityTypeConfiguration<ProductAttributeInt>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeInt> builder)
        {
            builder.ToTable(AnvuEcommerceConsts.DbTablePrefix + "ProductAttributeInts");
            builder.HasKey(x => x.Id);
        }
    }
}
