using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AppUpdaterApplicationModule),
    typeof(AppUpdaterDomainTestModule)
    )]
public class AppUpdaterApplicationTestModule : AbpModule
{

}
