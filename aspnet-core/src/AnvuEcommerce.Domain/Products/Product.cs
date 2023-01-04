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
        public Product() { }
        public Product(Guid id,Guid manufacturerId, string name, string code, ProductType productType, string sKU, double sellPrice, int sortOrder, bool visibility, bool isActive, Guid categoryId, string slug, string seoMetaDescription, string description, string thumbnailPicture, string categoryName, string categorySlug)
        {
            Id = id;
            ManufacturerId = manufacturerId;
            Name = name;
            Code = code;
            ProductType = productType;
            SKU = sKU;
            SellPrice = sellPrice;
            SortOrder = sortOrder;
            Visibility = visibility;
            IsActive = isActive;
            CategoryId = categoryId;
            Slug = slug;
            SeoMetaDescription = seoMetaDescription;
            Description = description;
            ThumbnailPicture = thumbnailPicture;
            CategoryName = categoryName;
            CategorySlug = categorySlug;
        }

        public Guid ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ProductType ProductType { get; set; }
        public string SKU { get; set; }
        public double SellPrice { get; set; }

        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public string Slug { get; set; }
        public string SeoMetaDescription { get; set; }
        public string Description { get; set; }
        public string ThumbnailPicture { get; set; }
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }

    }
}
