using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_EX6
{
    public abstract class BaseLogHandler
    {
        protected BaseLogHandler next;

        public abstract void Log(string msg, int currlevel);
        public void SetNext(BaseLogHandler next)
        {
            this.next = next;
        }

    }
}
