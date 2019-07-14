using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_ex2
{
    class Saguie : Vehicle
    {
        protected string MaxSpeed;

        public Saguie(string model, float cylinder, string color, int numberOfWheels, string MaxSpeed) : base(model, cylinder, color, numberOfWheels)
        {
            this.MaxSpeed = MaxSpeed;
        }

        public override string ToString()
        {
            return "Saguie : " + base.ToString() + $" { MaxSpeed}";
        }
    }
}
