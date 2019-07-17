using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory ClientsCreator = new ProxyFactory();
            ClinetProxy custumer = ClientsCreator.Login("Michael", "1234");
            ClinetProxy company = ClientsCreator.Login("ElAl", "4321");
            ClinetProxy admin = ClientsCreator.Login("admin", "admin");

            Console.WriteLine("customer function");
            ((CustomerProxy)custumer).BuyTicket();
            ((CustomerProxy)custumer).ShowMyTicket();

            Console.WriteLine("====================");

            Console.WriteLine("company function");
            ((CompanyProxy)company).CreateFlight();
            ((CompanyProxy)company).CancelFlight();

            Console.WriteLine("====================");

            Console.WriteLine("admin function");
            ((AdminProxy)admin).CreateCompany();
            ((AdminProxy)admin).CreateCustomer();
        }
    }
}
