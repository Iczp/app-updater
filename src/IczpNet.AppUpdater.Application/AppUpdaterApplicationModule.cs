using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using IczpNet.AbpCommons;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AppUpdaterDomainModule),
    typeof(AppUpdaterApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
    [DependsOn(typeof(AbpCommonsApplicationModule))]
public class AppUpdaterApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AppUpdaterApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AppUpdaterApplicationModule>(validate: true);
        });
    }
}
