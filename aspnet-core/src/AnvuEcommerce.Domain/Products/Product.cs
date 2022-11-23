﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace AnvuEcommerce.Products
{
    public class Product:AuditedAggregateRoot<Guid>
    {
        public Guid ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ProductType ProductType { get; set; }
        public string Sku { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public string SeoMetaDescription { get; set; }
        public string Description { get; set; }
        public string ThumbnailPicture { get; set; }

    }
}
