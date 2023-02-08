using AnvuEcommerce.Localization;
 using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AnvuEcommerce.Public.Permissions;

public class AnvuEcommercePublicPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AnvuEcommercePublicPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PublicPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AnvuEcommerceResource>(name);
    }
}
