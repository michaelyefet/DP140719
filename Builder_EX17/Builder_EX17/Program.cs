using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_EX17
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<HamburgerBuilder> menu = new List<HamburgerBuilder>();
            //menu.Add(new VeggHamburgerBuilder());
            //menu.Add(new VeggHambBuilderLettuce());
            //menu.Add(new MeatBurgerBuilder());

            HumburgerFactory factory = new HumburgerFactory();

            Console.WriteLine(factory.createHumburger("Meat").ToString());
            Console.WriteLine("===================================");
            Console.WriteLine(factory.createHumburger("regular_Vegg").ToString());
            Console.WriteLine("===================================");
            Console.WriteLine(factory.createHumburger("lettuce_Vegg").ToString());
        }

        
    }
}
