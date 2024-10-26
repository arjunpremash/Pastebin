using Pastebin.DataAccessContract;
using Pastebin.DataAccessContract.DTO;
using Pastebin.ServiceContract;
using Pastebin.ServiceContract.ViewModel;

namespace Pastebin.Service
{
    public class PasteService : IPasteService
    {
        private readonly IPasteDataAccess _pasteDataAccess;
        public PasteService(IPasteDataAccess pasteDataAccess) 
        {
            _pasteDataAccess = pasteDataAccess;   
        }
        public async Task AddPaste(PasteViewModel paste)
        {
            await _pasteDataAccess.CreatePaste(new PasteDTO()
            {
                Content = paste.content,
                CreatedAt = DateTime.UtcNow,
            });
        }
    }
}
