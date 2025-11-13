using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IczpNet.AppUpdater.MongoDB;

[ConnectionStringName(AppUpdaterDbProperties.ConnectionStringName)]
public class AppUpdaterMongoDbContext : AbpMongoDbContext, IAppUpdaterMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureAppUpdater();
    }
}
