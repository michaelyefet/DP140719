using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShowStatusProxy myStatusCarProxy = new CarShowStatusProxy();
            Console.WriteLine("The actions that the CarProxy has:");
            myStatusCarProxy.ShowLocation();
            myStatusCarProxy.ShowFuel();
            
        }
    }
}
