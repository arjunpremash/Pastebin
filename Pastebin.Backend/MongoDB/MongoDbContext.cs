using MongoDB.Driver;
using MongoDB.Entity;

namespace MongoDB
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("PasteBin");
        }

        public IMongoCollection<Paste> Pastes
        {
            get { return _mongoDatabase.GetCollection<Paste>("Pastes"); }
        }
    }
}
