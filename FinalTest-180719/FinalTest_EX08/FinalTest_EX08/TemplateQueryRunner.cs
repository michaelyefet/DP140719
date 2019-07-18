using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX08
{
    public abstract class TemplateQueryRunner
    {          
        public void Exercise()
        {
            ChangeClothes();
            DrinkWater();
            ExecuteWork();
            MakeShower();
        }

        protected abstract void ChangeClothes();
        protected abstract void DrinkWater();
        protected abstract void ExecuteWork();
        protected abstract void MakeShower();
    }
}
