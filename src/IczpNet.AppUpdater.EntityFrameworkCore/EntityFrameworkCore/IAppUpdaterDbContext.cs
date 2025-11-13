using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.AppUpdater.EntityFrameworkCore;

[ConnectionStringName(AppUpdaterDbProperties.ConnectionStringName)]
public interface IAppUpdaterDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
