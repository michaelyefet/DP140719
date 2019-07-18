using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX5
{
    public abstract class LogHandlerBase
    {
        protected LogHandlerBase nextHandelr;
        public abstract void Handle(string log, int level);

        public void SetNext(LogHandlerBase nextHandelr)
        {
            this.nextHandelr = nextHandelr;
        }
    }
}
