using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_EX15
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new BasePizza();

            IPizza pizzaWithTomato = new TomatoTopping(pizza);
            IPizza pizzaWithTomatoAndPineapple = new PineaappleTopping(pizzaWithTomato);
            IPizza pizzWithTomatoAndPineappleAndMushroom = new MushroomTopping(pizzaWithTomatoAndPineapple);
            IPizza pizzWithTomatoAndPineappleAndMushroomAndHalfPrice = new HalfPrice(pizzWithTomatoAndPineappleAndMushroom);

            Console.WriteLine(pizzWithTomatoAndPineappleAndMushroom.GetDetails());
            Console.WriteLine("The price is: " + pizzWithTomatoAndPineappleAndMushroom.GetPrice());

            Console.WriteLine("================================");

            Console.WriteLine(pizzWithTomatoAndPineappleAndMushroomAndHalfPrice.GetDetails());
            Console.WriteLine("The price is: " + pizzWithTomatoAndPineappleAndMushroomAndHalfPrice.GetPrice());


            IPizza myfavoritePizza = new TomatoTopping(new CheeseTopping(new BasePizza()));
        }
    }
}
