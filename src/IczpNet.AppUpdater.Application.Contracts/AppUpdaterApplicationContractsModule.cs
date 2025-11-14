using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using IczpNet.AbpCommons;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AppUpdaterDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
    [DependsOn(typeof(AbpCommonsApplicationContractsModule))]
public class AppUpdaterApplicationContractsModule : AbpModule
{

}
