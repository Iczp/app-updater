using IczpNet.AbpCommons.DataFilters;
using IczpNet.AppUpdater.AppVersionDevices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IczpNet.AppUpdater.AppDevices;

public class AppDevice : BaseEntity<Guid>, IIsEnabled
{
    /// <summary>
    /// Category
    /// </summary>
    [StringLength(64)]
    [Required]
    public virtual string? Category { get; set; }

    /// <summary>
    /// DisplayName
    /// </summary>
    [StringLength(64)]
    [Required]
    public virtual string? DisplayName { get; set; }

    /// <summary>
    /// DeviceType
    /// </summary>
    [StringLength(64)]
    [Required]
    public virtual string? DeviceType { get; set; }

    /// <summary>
    /// DeviceId
    /// </summary>
    [StringLength(128)]
    [Required]
    public virtual string? DeviceId { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    [StringLength(512)]
    [Required]
    public virtual string? Remark { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public virtual bool IsEnabled { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public virtual IList<AppVersionDevice> AppVersionDeviceList { get; set; } = [];

}
