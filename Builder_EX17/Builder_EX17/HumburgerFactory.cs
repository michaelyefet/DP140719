using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_EX17
{
    public class HumburgerFactory
    {
        public Hamburger createHumburger(string BurgerName)
        {
            switch (BurgerName)
            {
                case ("Meat"):
                    {
                        MeatBurgerBuilder currBurger = new MeatBurgerBuilder();
                        currBurger.BuildHamburger();
                        return currBurger.GetHamburger();
                    }

                case ("regular_Vegg"):
                    {
                        VeggHamburgerBuilder currBurger = new VeggHamburgerBuilder();
                        currBurger.BuildHamburger();
                        return currBurger.GetHamburger();
                    }

                case ("lettuce_Vegg"):
                    {
                        VeggHambBuilderLettuce currBurger = new VeggHambBuilderLettuce();
                        currBurger.BuildHamburger();
                        return currBurger.GetHamburger();
                    }

                default:
                    throw new HamburgerNotReadyException("This Hmburger dosent exist!");
                    
            }
        }
    }
}
