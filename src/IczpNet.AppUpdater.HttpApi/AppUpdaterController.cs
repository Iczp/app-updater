using IczpNet.AppUpdater.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IczpNet.AppUpdater;

public abstract class AppUpdaterController : AbpControllerBase
{
    protected AppUpdaterController()
    {
        LocalizationResource = typeof(AppUpdaterResource);
    }
}
