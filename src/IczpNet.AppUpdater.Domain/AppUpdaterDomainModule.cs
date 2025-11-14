using IczpNet.AbpCommons;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AppUpdaterDomainSharedModule)
)]
[DependsOn(typeof(AbpCommonsDomainModule))]
public class AppUpdaterDomainModule : AbpModule
{

}
