using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace IczpNet.AppUpdater.MongoDB;

[ConnectionStringName(AppUpdaterDbProperties.ConnectionStringName)]
public interface IAppUpdaterMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
