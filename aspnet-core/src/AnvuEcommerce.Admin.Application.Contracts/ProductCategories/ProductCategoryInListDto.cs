using System;
using System.Collections.Generic;
using System.Text;

namespace AnvuEcommerce.Admin.ProductCategories
{
    public class ProductCategoryInListDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int SortOrder { get; set; }
        public string CoverPicture { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
    }
}
