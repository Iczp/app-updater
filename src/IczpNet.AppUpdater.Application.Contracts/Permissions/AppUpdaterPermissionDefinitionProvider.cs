using IczpNet.AbpCommons.Permissions;
using IczpNet.AppUpdater.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IczpNet.AppUpdater.Permissions;

public class AppUpdaterPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AppUpdaterPermissions.GroupName, L("Permission:AppUpdater"));

        // 自动加入权限
        myGroup.AddPermissions<AppUpdaterPermissions>(x => L($"{x}"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AppUpdaterResource>(name);
    }
}
