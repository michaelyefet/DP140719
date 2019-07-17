using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoreator_EX16
{
    class Add : CalcDecorator
    {
        public Add(IFormula IFormula, double numToCalc):base(IFormula, numToCalc)
        {
                
        }
        public override string GetFormula()
        {
           return $"{this.IFormula.GetFormula()} + {this.numToCalc} ";
        }

        public override double GetResult()
        {
            return (this.IFormula.GetResult() + this.numToCalc);
        }
    }
}
