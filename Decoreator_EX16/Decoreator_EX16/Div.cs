using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoreator_EX16
{
    class Div : CalcDecorator
    {
        public Div(IFormula IFormula, double numToCalc):base(IFormula, numToCalc)
        {

        }
        public override string GetFormula()
        {
            return $"{this.IFormula.GetFormula()} / {this.numToCalc} ";
        }

        public override double GetResult()
        {
            return (this.IFormula.GetResult() / this.numToCalc);
        }
    }
}
