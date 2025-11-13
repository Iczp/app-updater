using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

[DependsOn(
    typeof(AppUpdaterDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class AppUpdaterEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AppUpdaterDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
