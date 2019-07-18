using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX3
{
    public class CarDAO
    {
       public void StartDriving()
        {
            Console.WriteLine("Start drive");
        }

        public void EndDriving()
        {
            Console.WriteLine("End drive");
        }

        public void IncreaseSpeedOfCar()
        {
            Console.WriteLine("Increaasing the car's speed");
        }

        public void DecreaseSpeedOfCar()
        {
            Console.WriteLine("Decreaasing the car's speed");
        }

        public void TurningRight()
        {
            Console.WriteLine("Turning the car right");
        }

        public void TurningLeft()
        {
            Console.WriteLine("Turning the car left");
        }

        public void ShowStateOfFuel()
        {
            Console.WriteLine("Showing the fuel's amount");
        }

        public void ShowMyLocation()
        {
            Console.WriteLine("Showing the car location");
        }
    }
}
