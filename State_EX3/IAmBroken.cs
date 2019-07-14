using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX3
{
    class IAmBroken : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("fixing the problem");
            return new IAmOff();
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("Broken");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Broken");
            return this;
        }
    }
}
