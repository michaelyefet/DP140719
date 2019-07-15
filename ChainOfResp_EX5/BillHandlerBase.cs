using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp_EX5
{
    public abstract class BillHandlerBase
    {

        protected BillHandlerBase next;

        public abstract void Handle(int amount);

        public void SetNext(BillHandlerBase next)
        {
            this.next = next;
        }

    }
}
