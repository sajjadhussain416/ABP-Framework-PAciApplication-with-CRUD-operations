using PaciApplication.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PaciApplication.Permissions;

public class PaciApplicationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PaciApplicationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PaciApplicationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PaciApplicationResource>(name);
    }
}
