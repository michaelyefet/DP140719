using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    class FlightDAO
    {
        public void InsertTicket()
        {
            Console.WriteLine("Create a ticket for the customer");
        }

        public void GetTicket()
        {
            Console.WriteLine("getting all the tickets for the customer");
        }

        public void InsertFlight()
        {
            Console.WriteLine("Create a Flight for the customer");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("cancel this flights");
        }

        public void InsertCustomer()
        {
            Console.WriteLine("Create customer");
        }

        public void InsertCompany()
        {
            Console.WriteLine("Create company");
        }

    }
}
