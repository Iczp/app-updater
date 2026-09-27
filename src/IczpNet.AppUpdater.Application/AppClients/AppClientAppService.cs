using IczpNet.AppUpdater.Permissions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IczpNet.AppUpdater.AppClients;

/// <inheritdoc />
public class AppClientAppService(IAppClientRepository repository) : CrudAppServiceBase<AppClient, AppClientDetailDto, AppClientDto, Guid, AppClientGetListInput, AppClientCreateInput, AppClientUpdateInput>(repository), IAppClientAppService
{
    protected override string? GetPolicyName { get; set; } = AppUpdaterPermissions.AppClientPermissions.GetItem;
    protected override string? GetListPolicyName { get; set; } = AppUpdaterPermissions.AppClientPermissions.GetList;
    protected override string? CreatePolicyName { get; set; } = AppUpdaterPermissions.AppClientPermissions.Create;
    protected override string? UpdatePolicyName { get; set; } = AppUpdaterPermissions.AppClientPermissions.Update;
    protected override string? DeletePolicyName { get; set; } = AppUpdaterPermissions.AppClientPermissions.Delete;
    protected override string? SetIsEnabledPolicyName { get; set; } = AppUpdaterPermissions.AppClientPermissions.SetIsEnabled;

    /// <inheritdoc />
    protected override async Task<IQueryable<AppClient>> CreateFilteredQueryAsync(AppClientGetListInput input)
    {
        return (await base.CreateFilteredQueryAsync(input))
            //.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword))
            ;
    }
}
