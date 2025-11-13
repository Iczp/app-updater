using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

public class AppUpdaterHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AppUpdaterHttpApiHostMigrationsDbContext>
{
    public AppUpdaterHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AppUpdaterHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AppUpdater"));

        return new AppUpdaterHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
