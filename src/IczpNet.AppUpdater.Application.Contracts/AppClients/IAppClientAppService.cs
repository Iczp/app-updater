using System;

namespace IczpNet.AppUpdater.AppClients;

public interface IAppClientAppService : ICrudAppServiceBase<AppClientDetailDto, AppClientDto, Guid, AppClientGetListInput, AppClientCreateInput, AppClientUpdateInput>
{

}
