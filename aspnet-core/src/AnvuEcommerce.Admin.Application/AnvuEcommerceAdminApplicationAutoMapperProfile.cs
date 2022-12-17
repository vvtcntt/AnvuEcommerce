using AnvuEcommerce.Admin.Manufacturers;
using AnvuEcommerce.Admin.ProductCategories;
using AnvuEcommerce.Admin.Products;
using AnvuEcommerce.Manufacturers;
using AnvuEcommerce.ProductCategories;
using AnvuEcommerce.Products;
using AutoMapper;

namespace AnvuEcommerce;

public class AnvuEcommerceAdminApplicationAutoMapperProfile : Profile
{
    public AnvuEcommerceAdminApplicationAutoMapperProfile()
    {
       //product category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();
        //product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        //Manufacturers
        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Manufacturer, ManufacturerInListDto>();
        CreateMap<CreateUpdateManufacturerDto, Manufacturer>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
