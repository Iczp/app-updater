using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AppUpdaterInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AppUpdaterInstallerModule>();
        });
    }
}
