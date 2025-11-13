using IczpNet.AppUpdater.MongoDB;
using IczpNet.AppUpdater.Samples;
using Xunit;

namespace IczpNet.AppUpdater.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<AppUpdaterMongoDbTestModule>
{

}
