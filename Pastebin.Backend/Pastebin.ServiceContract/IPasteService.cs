using Pastebin.ServiceContract.ViewModel;

namespace Pastebin.ServiceContract
{
    public interface IPasteService
    {
        public Task AddPaste(PasteViewModel paste); 
    }
}
