using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastebin.DataAccessContract.DTO
{
    public class PasteDTO
    {
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
