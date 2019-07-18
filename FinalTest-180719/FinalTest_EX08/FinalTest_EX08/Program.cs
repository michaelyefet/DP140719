using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting shoulders execise:");
            PracticeTemplateBase shouldersPractice = new PracticeShoulders();
            shouldersPractice.Exercise();
            Console.WriteLine();

            Console.WriteLine("Starting legs execise:");
            PracticeTemplateBase legsPractice = new PracticeLegs();
            legsPractice.Exercise();
            Console.WriteLine();

            Console.WriteLine("Starting chest execise:");
            PracticeTemplateBase chestPractice = new PracticeChest();
            chestPractice.Exercise();
            Console.WriteLine();

            

            
        }
    }
}
