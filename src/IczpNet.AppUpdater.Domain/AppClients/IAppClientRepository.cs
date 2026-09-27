using System;
using Volo.Abp.Domain.Repositories;


namespace IczpNet.AppUpdater.AppClients;

public interface IAppClientRepository : IRepository<AppClient, Guid>
{

}
