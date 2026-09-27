using IczpNet.AppUpdater.EntityFrameworkCore;
using System;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.AppUpdater.AppClients;

/// <inheritdoc />
public class AppClientRepository(IDbContextProvider<AppUpdaterDbContext> dbContextProvider) : AppUpdaterRepository<AppClient, Guid>(dbContextProvider), IAppClientRepository
{
    
}

