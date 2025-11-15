using Volo.Abp.Reflection;

namespace IczpNet.AppUpdater.Permissions;

public class AppUpdaterPermissions
{
    public const string GroupName = "AppUpdater";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AppUpdaterPermissions));
    }

    /*---------code-generator-permissions: Do not modify or delete this line of comments--------*/
}
