using AnvuEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AnvuEcommerce.Admin.Permissions;

public class AnvuEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Catalog
        var catalogGroup = context.AddGroup(AnvuEcommercePermissions.CatalogGroupName, L("Permission:Catalog"));
        //Manufacture
        var manufacturerPermission = catalogGroup.AddPermission(AnvuEcommercePermissions.Manufacturer.Default, L("Permission:Catalog.Manufacturer"));
        manufacturerPermission.AddChild(AnvuEcommercePermissions.Manufacturer.Create, L("Permission:Catalog.Manufacturer.Create"));
        manufacturerPermission.AddChild(AnvuEcommercePermissions.Manufacturer.Update, L("Permission:Catalog.Manufacturer.Update"));
        manufacturerPermission.AddChild(AnvuEcommercePermissions.Manufacturer.Delete, L("Permission:Catalog.Manufacturer.Delete"));

        //Product Category
        var productCategoryPermission = catalogGroup.AddPermission(AnvuEcommercePermissions.ProductCategory.Default, L("Permission:Catalog.ProductCategory"));
        productCategoryPermission.AddChild(AnvuEcommercePermissions.ProductCategory.Create, L("Permission:Catalog.ProductCategory.Create"));
        productCategoryPermission.AddChild(AnvuEcommercePermissions.ProductCategory.Update, L("Permission:Catalog.ProductCategory.Update"));
        productCategoryPermission.AddChild(AnvuEcommercePermissions.ProductCategory.Delete, L("Permission:Catalog.ProductCategory.Delete"));
        //Add product
        var productPermission = catalogGroup.AddPermission(AnvuEcommercePermissions.Product.Default, L("Permission:Catalog.Product"));
        productPermission.AddChild(AnvuEcommercePermissions.Product.Create, L("Permission:Catalog.Product.Create"));
        productPermission.AddChild(AnvuEcommercePermissions.Product.Update, L("Permission:Catalog.Product.Update"));
        productPermission.AddChild(AnvuEcommercePermissions.Product.Delete, L("Permission:Catalog.Product.Delete"));
        productPermission.AddChild(AnvuEcommercePermissions.Product.AttributeManage, L("Permission:Catalog.Product.AttributeManage"));

        //Add attribute
        var attributePermission = catalogGroup.AddPermission(AnvuEcommercePermissions.Attribute.Default, L("Permission:Catalog.Attribute"));
        attributePermission.AddChild(AnvuEcommercePermissions.Attribute.Create, L("Permission:Catalog.Attribute.Create"));
        attributePermission.AddChild(AnvuEcommercePermissions.Attribute.Update, L("Permission:Catalog.Attribute.Update"));
        attributePermission.AddChild(AnvuEcommercePermissions.Attribute.Delete, L("Permission:Catalog.Attribute.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AnvuEcommerceResource>(name);
    }
}
