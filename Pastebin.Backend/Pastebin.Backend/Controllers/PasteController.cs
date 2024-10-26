using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pastebin.ServiceContract;
using Pastebin.ServiceContract.ViewModel;

namespace Pastebin.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasteController : ControllerBase
    {
        private readonly IPasteService _pasteService;

        public PasteController(IPasteService pasteService)
        {
            _pasteService = pasteService;
        }

        [HttpPost]
        public async Task AddPaste(string paste)
        {
            await _pasteService.AddPaste(new PasteViewModel()
            {
                content = paste
            });
        }
    }
}
