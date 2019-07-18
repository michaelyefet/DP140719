using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX08
{
    public abstract class PracticeTemplateBase : TemplateQueryRunner
    {
        protected override void ChangeClothes()
        {
            Console.WriteLine("\tChanging clothes");
        }
        protected override void DrinkWater()
        {
            Console.WriteLine("\tDrinking water");
        }
        protected override void MakeShower()
        {
            Console.WriteLine("\tMaking shower");
        }
    }
}
