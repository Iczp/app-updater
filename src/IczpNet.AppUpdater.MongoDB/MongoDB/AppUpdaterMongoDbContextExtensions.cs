using Volo.Abp;
using Volo.Abp.MongoDB;

namespace IczpNet.AppUpdater.MongoDB;

public static class AppUpdaterMongoDbContextExtensions
{
    public static void ConfigureAppUpdater(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
