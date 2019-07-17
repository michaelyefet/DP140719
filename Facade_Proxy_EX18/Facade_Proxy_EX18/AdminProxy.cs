using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    class AdminProxy : ClinetProxy, IAdmin
    {
        public void CreateCompany()
        {
            this.facade.CreateCompany();
        }

        public void CreateCustomer()
        {
            this.facade.CreateCustomer();
        }
    }
}
