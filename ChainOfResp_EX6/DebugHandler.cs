using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_EX6
{
    class DebugHandler : BaseLogHandler
    {
        private const int Loglevel = 4;
        public override void Log(string msg, int currlevel)
        {
            if (Loglevel == currlevel)
            {
                Console.WriteLine("Debug: " + msg);
            }
            else if(next != null)
            {
                next.Log(msg, currlevel);
            }
        }
    }
}
