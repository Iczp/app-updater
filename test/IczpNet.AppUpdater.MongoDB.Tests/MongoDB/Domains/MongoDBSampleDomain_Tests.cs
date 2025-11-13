using IczpNet.AppUpdater.Samples;
using Xunit;

namespace IczpNet.AppUpdater.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<AppUpdaterMongoDbTestModule>
{

}
