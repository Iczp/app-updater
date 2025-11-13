using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

[ConnectionStringName(AppUpdaterDbProperties.ConnectionStringName)]
public class AppUpdaterDbContext : AbpDbContext<AppUpdaterDbContext>, IAppUpdaterDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AppUpdaterDbContext(DbContextOptions<AppUpdaterDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAppUpdater();
    }
}
