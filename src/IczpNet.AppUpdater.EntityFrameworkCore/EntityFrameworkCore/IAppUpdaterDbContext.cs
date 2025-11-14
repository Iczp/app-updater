using IczpNet.AppUpdater.AppClients;
using IczpNet.AppUpdater.AppDevices;
using IczpNet.AppUpdater.AppVersionDevices;
using IczpNet.AppUpdater.AppVersions;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

[ConnectionStringName(AppUpdaterDbProperties.ConnectionStringName)]
public interface IAppUpdaterDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    DbSet<AppClient> AppClient { get; }
    DbSet<AppVersion> AppVersion { get; }
    DbSet<AppDevice> AppDevice { get; }
    DbSet<AppVersionDevice> AppVersionDevice { get; }
}
