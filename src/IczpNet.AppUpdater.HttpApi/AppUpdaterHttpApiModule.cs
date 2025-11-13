using Localization.Resources.AbpUi;
using IczpNet.AppUpdater.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AppUpdaterApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AppUpdaterHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AppUpdaterHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AppUpdaterResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
