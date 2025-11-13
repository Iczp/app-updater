using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class AppUpdaterDomainTestBase<TStartupModule> : AppUpdaterTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
