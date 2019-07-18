using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX12
{
    class Program
    {
        static void Main(string[] args)
        {

            ComputerFactory factory = new ComputerFactory();

            Console.WriteLine("LIVING ROOM: " + factory.createComputer("living room"));
            Console.WriteLine("WORK: " + factory.createComputer("work"));
            Console.WriteLine("GAME: " + factory.createComputer("game"));

            //if you want to create computer that doesnt exist is will throw exception your can see if you enable the lower line
            //Console.WriteLine("PROGRAMMING: " + factory.createComputer("programming"));


        }
    }
}
