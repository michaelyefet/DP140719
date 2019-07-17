using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    abstract class ClinetProxy
    {
        protected FlightSystemFacade facade = new FlightSystemFacade();
    }
}
