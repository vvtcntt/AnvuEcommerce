﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnvuEcommerce.Admin.Products
{
    public class ProductListFilterDto:BaseListFilterDto
    {
        public Guid? CategoryId { get; set; }
    }
}
