using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    class ProxyFactory
    {
        public ClinetProxy Login(string uName, string Pass)
        {
            if ((uName.Equals("Michael"))&&(Pass.Equals("1234")))
            {
                return new CustomerProxy();
            }
            else if ((uName.Equals("ElAl")) && (Pass.Equals("4321")))
            {
                return new CompanyProxy();
            }
            else if ((uName.Equals("admin")) && (Pass.Equals("admin")))
            {
                return new AdminProxy();
            }
            else
            {
                return null;
            }
        }
    }
}
