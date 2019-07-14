using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_EX3
{
    public class IAmOn : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("there isn't a problem to fix");
            return this;
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("Turning off the light....");
            return new IAmOff();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("was already on...now i am broken");
            return new IAmBroken();
        }
    }
}
