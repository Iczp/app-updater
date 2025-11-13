using Volo.Abp.Modularity;

namespace IczpNet.AppUpdater;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class AppUpdaterApplicationTestBase<TStartupModule> : AppUpdaterTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
