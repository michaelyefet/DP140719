using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Proxy_EX18
{
    class FlightSystemFacade : ICustomer, ICompany, IAdmin
    {
        FlightDAO DBaccess = new FlightDAO();
        public void BuyTicket()
        {
            DBaccess.InsertTicket();
        }

        public void CancelFlight()
        {
            DBaccess.RemoveFlight();
        }

        public void CreateCompany()
        {
            DBaccess.InsertCompany();
        }

        public void CreateCustomer()
        {
            DBaccess.InsertCustomer();
        }

        public void CreateFlight()
        {
            DBaccess.InsertFlight();
        }

        public void ShowMyTicket()
        {
            DBaccess.GetTicket();
        }
    }
}
