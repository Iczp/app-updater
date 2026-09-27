using Volo.Abp.Reflection;

namespace IczpNet.AppUpdater.Permissions;

public class AppUpdaterPermissions
{
    public const string GroupName = "AppUpdater";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AppUpdaterPermissions));
    }

    
    /// <summary>
    /// AppClient
    /// </summary>
    public class AppClientPermissions
    {
        public const string Default = GroupName + $".{nameof(AppClientPermissions)}";
        public const string GetItem = Default + ".GetItem";
        public const string GetList = Default + ".GetList";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
        public const string SetIsEnabled = Default + ".SetIsEnabled";
    }
    

    /*---------code-generator-permissions: Do not modify or delete this line of comments--------*/
}
