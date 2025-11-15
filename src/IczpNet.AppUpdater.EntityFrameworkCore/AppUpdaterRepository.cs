using IczpNet.AppUpdater.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Timing;

namespace IczpNet.AppUpdater;

public abstract class AppUpdaterRepository<TEntity, TPrimaryKey>(IDbContextProvider<AppUpdaterDbContext> dbContextProvider) : EfCoreRepository<AppUpdaterDbContext, TEntity, TPrimaryKey>(dbContextProvider), IAppUpdaterRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
{
    protected IClock Clock => LazyServiceProvider.LazyGetRequiredService<IClock>();

    public async Task<IEnumerable<TEntity>> FindManyAsync(IEnumerable<TPrimaryKey> idList)
    {
        return await GetListAsync(x => idList.Contains(x.Id));
    }

    public async Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TPrimaryKey> idList)
    {
        var list = new List<TEntity>();
        foreach (var id in idList)
        {
            var entity = await GetAsync(id);
            list.Add(entity);
        }
        return list;
    }
}
