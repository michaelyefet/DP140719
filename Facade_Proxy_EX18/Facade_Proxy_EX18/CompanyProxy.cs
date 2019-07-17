using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    class CompanyProxy : ClinetProxy, ICompany
    {
        public void CancelFlight()
        {
            this.facade.CancelFlight();
        }

        public void CreateFlight()
        {
            this.facade.CreateFlight();
        }
    }
}
