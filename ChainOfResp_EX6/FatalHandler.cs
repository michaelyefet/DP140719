using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_EX6
{
    class FatalHandler : BaseLogHandler
    {
        private const int Loglevel = 1;
        public override void Log(string msg, int currlevel)
        {
            if (Loglevel == currlevel)
            {
                Console.WriteLine("Fatal: " + msg);
            }
            else if (next != null)
            {
                next.Log(msg, currlevel);
            }
        }
    }
}
