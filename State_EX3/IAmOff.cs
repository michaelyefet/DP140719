using System;

namespace State_EX3
{
    public class IAmOff : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("there isn't a problem to fix");
            return this;
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("was already off...now i am broken");
            return new IAmBroken();
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("Turning on the light!");
            return new IAmOn();
        }
    }
}
