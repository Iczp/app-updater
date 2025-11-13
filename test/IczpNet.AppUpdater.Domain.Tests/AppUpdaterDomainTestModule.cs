using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AppUpdaterDomainModule),
    typeof(AppUpdaterTestBaseModule)
)]
public class AppUpdaterDomainTestModule : AbpModule
{

}
