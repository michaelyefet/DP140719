using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new IAmOn());
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOff();
            ctx.Fix();
            ctx.pressedOn();
            ctx.pressedOff();
            ctx.pressedOff();
            ctx.Fix();
            ctx.pressedOn();
        }
    }
}
