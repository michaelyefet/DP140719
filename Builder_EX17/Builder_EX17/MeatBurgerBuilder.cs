using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_EX17
{
    class MeatBurgerBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Healthy flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("red meat 300 grams");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("serop maypel");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("lettuce and picels");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 75 ILS");
        }
    }
}
