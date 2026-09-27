using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.AppUpdater.AppClients;

/// <summary>
/// 新增或修改
/// </summary>
[Serializable]
public class AppClientCreateOrUpdateInput : AppClientCreateInput, IEntityDto<Guid?>
{
    /// <summary>
    /// 
    /// </summary>
    public Guid? Id { get; set; }
}