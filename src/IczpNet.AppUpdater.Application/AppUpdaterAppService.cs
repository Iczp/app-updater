using IczpNet.AppUpdater.Localization;
using Volo.Abp.Application.Services;

namespace IczpNet.AppUpdater;

public abstract class AppUpdaterAppService : ApplicationService
{
    protected AppUpdaterAppService()
    {
        LocalizationResource = typeof(AppUpdaterResource);
        ObjectMapperContext = typeof(AppUpdaterApplicationModule);
    }
}
