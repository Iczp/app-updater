using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AppUpdaterDomainSharedModule)
)]
public class AppUpdaterDomainModule : AbpModule
{

}
