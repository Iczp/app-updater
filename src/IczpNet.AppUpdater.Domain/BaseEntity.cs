using IczpNet.AbpCommons.DataFilters;
using Volo.Abp.Domain.Entities.Auditing;

namespace IczpNet.AppUpdater;

public abstract class BaseEntity : AuditedAggregateRoot//, IMultiTenant//, ISorting
{
    //public virtual Guid? TenantId { get; set; }
}

public abstract class BaseEntity<TKey> : FullAuditedAggregateRoot<TKey> , IIsEnabled//, IMultiTenant//, IIsActive, IIsStatic, IIsEnabled
{
    //public virtual Guid? TenantId { get; set; }
    protected BaseEntity() { }
    protected BaseEntity(TKey id) : base(id) { }

    /// <summary>
    /// 
    /// </summary>
    public virtual bool IsEnabled { get; set; }

    public virtual void SetIsEnabled(bool isEnabled)
    {
        IsEnabled = isEnabled;
    }
}