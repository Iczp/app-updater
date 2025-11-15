using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.AppUpdater;

public interface IAppUpdaterRepository<TEntity, TKey> : IRepository<TEntity, TKey>, IAppUpdaterRepository
    where TEntity : class, IEntity<TKey>
{
    /// <summary>
    /// 获取多个
    /// </summary>
    /// <param name="idList"></param>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> idList);

    /// <summary>
    /// 获取多个
    /// </summary>
    /// <param name="idList"></param>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> FindManyAsync(IEnumerable<TKey> idList);
}

public interface IAppUpdaterRepository : IRepository
{
}
