using IczpNet.AbpCommons;
using System.Threading.Tasks;

namespace IczpNet.AppUpdater;

public interface ICrudAppServiceBase<TGetOutputDto, TGetListOutputDto, TKey, TGetListInput, TCreateInput, TUpdateInput> : ICrudAbpCommonsAppService<TGetOutputDto, TGetListOutputDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
{

    Task<bool> SetIsEnabledAsync(TKey id, bool isEnabled);
}