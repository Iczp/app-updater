using IczpNet.AppUpdater.AppClients;
using IczpNet.AppUpdater.AppDevices;
using IczpNet.AppUpdater.AppVersionDevices;
using IczpNet.AppUpdater.AppVersions;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

[ConnectionStringName(AppUpdaterDbProperties.ConnectionStringName)]
public class AppUpdaterDbContext(DbContextOptions<AppUpdaterDbContext> options) : AbpDbContext<AppUpdaterDbContext>(options), IAppUpdaterDbContext
{
    public DbSet<AppClient> AppClient { get; set; }

    public DbSet<AppVersion> AppVersion { get; set; }

    public DbSet<AppDevice> AppDevice { get; set; }

    public DbSet<AppVersionDevice> AppVersionDevice { get; set; }

    /* Add DbSet for each Aggregate Root here. Example:
* public DbSet<Question> Questions { get; set; }
*/


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAppUpdater();
    }
}
