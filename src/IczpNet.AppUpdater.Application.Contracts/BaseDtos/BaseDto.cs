using Volo.Abp.Application.Dtos;

namespace IczpNet.AppUpdater.BaseDtos;

public class BaseDto<T> : EntityDto<T> where T : class
{
}
