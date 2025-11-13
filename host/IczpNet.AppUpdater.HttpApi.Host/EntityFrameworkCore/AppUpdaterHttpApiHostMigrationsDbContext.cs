using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

public class AppUpdaterHttpApiHostMigrationsDbContext : AbpDbContext<AppUpdaterHttpApiHostMigrationsDbContext>
{
    public AppUpdaterHttpApiHostMigrationsDbContext(DbContextOptions<AppUpdaterHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAppUpdater();
    }
}
