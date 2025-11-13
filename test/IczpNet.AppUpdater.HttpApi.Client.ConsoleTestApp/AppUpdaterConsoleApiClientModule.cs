using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AppUpdaterHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AppUpdaterConsoleApiClientModule : AbpModule
{

}
