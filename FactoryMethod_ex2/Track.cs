using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_ex2
{
    class Track : Vehicle
    {
        protected string WeightToCarry;

        public Track(string model, float cylinder, string color, int numberOfWheels, string WeightToCarry) : base(model, cylinder, color, numberOfWheels)
        {
            this.WeightToCarry = WeightToCarry;
        }

        public override string ToString()
        {
            return "Track : " + base.ToString() + $" { WeightToCarry}";
        }
    }
}
