using MongoDB;
using MongoDB.Driver;
using MongoDB.Entity;
using Pastebin.DataAccessContract;
using Pastebin.DataAccessContract.DTO;

namespace Pastebin.DataAccess
{
    public class PasteDataAccess : IPasteDataAccess
    {
        private readonly IMongoCollection<Paste> _pasteCollection;

        public PasteDataAccess(MongoDbContext mongoDbContext)
        {
            _pasteCollection = mongoDbContext.Pastes;
        }

        public async Task CreatePaste(PasteDTO paste)
        {
            await _pasteCollection.InsertOneAsync(new Paste()
            {
                Content = paste.Content,
                CreatedAt = paste.CreatedAt
            });
        }
    }
}
