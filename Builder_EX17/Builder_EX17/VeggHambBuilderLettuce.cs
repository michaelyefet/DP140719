using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_EX17
{
    public class VeggHambBuilderLettuce : VeggHamburgerBuilder
    {
        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Lettuces");
        }

    }
}
