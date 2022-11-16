using AnvuEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AnvuEcommerce.Permissions;

public class AnvuEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AnvuEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AnvuEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AnvuEcommerceResource>(name);
    }
}
