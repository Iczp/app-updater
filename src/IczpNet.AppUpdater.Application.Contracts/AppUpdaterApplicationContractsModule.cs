using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AppUpdaterDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class AppUpdaterApplicationContractsModule : AbpModule
{

}
