using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoreator_EX16
{
    public abstract class CalcDecorator : IFormula
    {
        protected IFormula IFormula;
        protected double numToCalc;

        public CalcDecorator(IFormula IFormula, double numToCalc)
        {
            this.IFormula = IFormula;
            this.numToCalc = numToCalc;
        }
        public abstract string GetFormula();
        public abstract double GetResult();
    }
}
