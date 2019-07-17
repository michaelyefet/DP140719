using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brifge_EX19
{
    class Program
    {
        static void Main(string[] args)
        {
            TV television = new TV(15,32,false);
            Memir mem = new Memir(16,50,true);
            RemoreControl Remote = new RemoreControl(television);
            Remote.On();
            Remote.PrintState();
            Remote.Next();
            Remote.PrintState();
            Remote.Next();
            Remote.PrintState();
            Remote.Next();
            Remote.PrintState();
            Remote.Next();

            Remote.SetDevice(mem);

            Console.WriteLine("=========================");
            Remote.On();
            Remote.Off();
            Remote.PrintState();
            Remote.Prev();
            Remote.PrintState();
            Remote.Prev();
            Remote.PrintState();
            Remote.Prev();
            Remote.PrintState();
            Remote.Prev();
        }
    }
}
