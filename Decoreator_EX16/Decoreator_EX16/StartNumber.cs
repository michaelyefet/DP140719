using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoreator_EX16
{
    class StartNumber : IFormula
    {
        double Number;

        public StartNumber(double Number)
        {
            this.Number = Number;
        }

        public void ModifyNumber(double Number)
        {
            this.Number = Number;
        }

        public string GetFormula()
        {
            return $"{this.Number}";
        }

        public double GetResult()
        {
            return this.Number;
        }
    }
}
