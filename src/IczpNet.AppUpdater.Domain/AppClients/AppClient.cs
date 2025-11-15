using IczpNet.AbpCommons.DataFilters;
using IczpNet.AppUpdater.AppVersions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IczpNet.AppUpdater.AppClients;

public class AppClient : BaseEntity<Guid>, IIsEnabled
{
    /// <summary>
    /// Name
    /// </summary>
    [StringLength(512)]
    public virtual string? Logo { get; set; }

    /// <summary>
    /// AppId
    /// </summary>
    [StringLength(64)]
    public virtual required string AppId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [StringLength(256)]
    public virtual string? Name { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    [StringLength(256)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// 开发设备Id
    /// </summary>
    [StringLength(256)]
    public virtual string? DevDevices { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public virtual IList<AppVersion> AppVersionList { get; set; } = [];

}
