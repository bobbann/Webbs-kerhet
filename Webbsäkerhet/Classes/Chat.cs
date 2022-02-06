using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webbsäkerhet.Classes
{
    public class Chat
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }

    }
}
