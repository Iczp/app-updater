using IczpNet.AppUpdater.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IczpNet.AppUpdater.Permissions;

public class AppUpdaterPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AppUpdaterPermissions.GroupName, L("Permission:AppUpdater"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AppUpdaterResource>(name);
    }
}
