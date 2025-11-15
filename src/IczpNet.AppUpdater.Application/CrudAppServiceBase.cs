using IczpNet.AbpCommons;
using IczpNet.AppUpdater.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Localization;

namespace IczpNet.AppUpdater;

[Area(AppUpdaterRemoteServiceConsts.ModuleName)]
[ApiExplorerSettings(GroupName = AppUpdaterRemoteServiceConsts.ModuleName)]

public abstract class CrudAppServiceBase<TEntity, TGetOutputDto, TGetListOutputDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
    : CrudAbpCommonsAppService<TEntity, TGetOutputDto, TGetListOutputDto, TKey, TGetListInput, TCreateInput, TUpdateInput>, ICrudAppServiceBase<TGetOutputDto, TGetListOutputDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
    where TEntity : BaseEntity<TKey>, IEntity<TKey>
//where TGetOutputDto : IEntityDto<TKey>
//where TGetListOutputDto : IEntityDto<TKey>


{

    protected virtual string? SetIsEnabledPolicyName { get; set; }

    protected CrudAppServiceBase(IRepository<TEntity, TKey> repository) : base(repository)
    {
        LocalizationResource = typeof(AppUpdaterResource);
        ObjectMapperContext = typeof(AppUpdaterApplicationModule);
    }


    public async Task<bool> SetIsEnabledAsync(TKey id, bool isEnabled)
    {
        await CheckSetIsEnabledPolicy();
        var entity = await Repository.GetAsync(id);
        entity.SetIsEnabled(isEnabled);
        return entity.IsEnabled;
    }

    protected virtual async Task CheckSetIsEnabledPolicy()
    {
        await CheckPolicyAsync(SetIsEnabledPolicyName);
    }

    protected virtual string NotFoundEntity(string name, object value)
    {
        return L["EntityNotFound", name, $"{value}"];
    }

    protected virtual string FindDuplicate<T>(IEnumerable<T> list)
    {
        return L["FindDuplicateItems", list.Count(), list.JoinAsString(",")];
    }
}