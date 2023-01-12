using AnvuEcommerce.Admin.Manufacturers;
using AnvuEcommerce.Admin.ProductAttributes;
using AnvuEcommerce.Admin.ProductCategories;
using AnvuEcommerce.Admin.Products;
using AnvuEcommerce.Admin.Roles;
using AnvuEcommerce.Admin.System.Users;
using AnvuEcommerce.Manufacturers;
using AnvuEcommerce.ProductAttributes;
using AnvuEcommerce.ProductCategories;
using AnvuEcommerce.Products;
using AnvuEcommerce.Roles;
using AutoMapper;
using Volo.Abp.Identity;

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

        //attribute
        CreateMap<ProductAttribute, ProductAttributeDto>();
        CreateMap<ProductAttribute, ProductAttributeInListDto>();
        CreateMap<CreateUpdateProductAttributeDto, ProductAttribute>();



        //Roles
        CreateMap<IdentityRole, RoleDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
            ?
            x.ExtraProperties[RoleConsts.DescriptionFieldName]
            :
            null));
        CreateMap<IdentityRole, RoleInListDto>().ForMember(x => x.Description,
            map => map.MapFrom(x => x.ExtraProperties.ContainsKey(RoleConsts.DescriptionFieldName)
            ?
            x.ExtraProperties[RoleConsts.DescriptionFieldName]
            :
            null));
        CreateMap<CreateUpdateRoleDto, IdentityRole>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        //User
        CreateMap<IdentityUser, UserDto>();
        CreateMap<IdentityUser, UserInListDto>();
    }
}
