using System;
using System.Collections.Generic;
using System.Text;

namespace AnvuEcommerce.Admin.Products.Attributes
{
    public class ProductAttributeListFilterDto : BaseListFilterDto
    {
        public Guid ProductId { get; set; }
    }
}
