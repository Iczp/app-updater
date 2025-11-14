using IczpNet.AppUpdater.AppDevices;
using IczpNet.AppUpdater.AppVersions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.AppUpdater.AppVersionDevices;

public class AppVersionDevice : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public virtual Guid AppDeviceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [ForeignKey(nameof(AppDeviceId))]
    public virtual required AppDevice AppDevice { get; set; }


    /// <summary>
    /// 
    /// </summary>
    public virtual Guid AppVersionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [ForeignKey(nameof(AppDeviceId))]
    public virtual required AppVersion AppVersion { get; set; }

    public override object?[] GetKeys()
    {
        return [AppDeviceId, AppVersionId];
    }
}
