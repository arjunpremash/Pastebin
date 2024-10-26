using Pastebin.DataAccessContract.DTO;

namespace Pastebin.DataAccessContract
{
    public interface IPasteDataAccess
    {
        public Task CreatePaste(PasteDTO paste);
    }
}
