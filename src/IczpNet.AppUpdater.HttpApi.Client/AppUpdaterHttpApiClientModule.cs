using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AppUpdaterApplicationContractsModule),
    typeof(AbpHttpClientModule))]

public class AppUpdaterHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AppUpdaterApplicationContractsModule).Assembly,
            AppUpdaterRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AppUpdaterHttpApiClientModule>();
        });

    }
}
