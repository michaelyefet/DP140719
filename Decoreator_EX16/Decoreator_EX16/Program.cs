using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoreator_EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            StartNumber formula = new StartNumber(2);
          
            IFormula NumAddNum = new Add(formula, 5.3);

            Console.WriteLine(NumAddNum.GetFormula());
            Console.WriteLine(NumAddNum.GetResult());
            Console.WriteLine("=================");

            formula.ModifyNumber(7.4);

            Console.WriteLine(NumAddNum.GetFormula());
            Console.WriteLine(NumAddNum.GetResult());
            Console.WriteLine("=================");


            IFormula NumDivNum = new Div(NumAddNum, 2);
            IFormula NumSubNum = new Sub(NumDivNum, 8.9);
            IFormula NumMulNum = new Mul(NumSubNum, 3);

            Console.WriteLine(NumMulNum.GetFormula());
            Console.WriteLine(NumMulNum.GetResult());
            Console.WriteLine("=================");




        }
    }
}
