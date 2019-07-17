using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    class CustomerProxy : ClinetProxy, ICustomer
    {
        public void BuyTicket()
        {
            this.facade.BuyTicket();
        }

        public void ShowMyTicket()
        {
            this.facade.ShowMyTicket();
        }
    }
}
