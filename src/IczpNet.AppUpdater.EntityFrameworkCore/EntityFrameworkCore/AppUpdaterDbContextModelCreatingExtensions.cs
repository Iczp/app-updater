using IczpNet.AbpCommons.EntityFrameworkCore;
using IczpNet.AppUpdater.AppClients;
using IczpNet.AppUpdater.AppVersionDevices;
using IczpNet.AppUpdater.AppVersions;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

public static class AppUpdaterDbContextModelCreatingExtensions
{
    public static void ConfigureAppUpdater(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(AppUpdaterDbProperties.DbTablePrefix + "Questions", AppUpdaterDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        // 自加实体配置
        builder.ConfigEntities<AppUpdaterDomainModule>(AppUpdaterDbProperties.DbTablePrefix, AppUpdaterDbProperties.DbSchema);

        builder.Entity<AppClient>(b =>
        {
            b.HasIndex(x => x.AppId).IsUnique(true);
        });

        builder.Entity<AppVersion>(b =>
        {
            b.HasIndex(x => x.AppClientId);
            b.HasIndex(x => new { x.AppClientId, x.VersionCode }).IsDescending([false, true]).IsUnique(true);
        });

        builder.Entity<AppVersionDevice>((b => { b.HasKey(x => new { x.AppVersionId, x.AppDeviceId }); }));
    }
}
