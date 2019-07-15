using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototupe_EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(new Point(5, 5), 50.5);

            Console.WriteLine(c);

            Circle bla = (Circle)c.clone();
            DoStuffWithCircle(bla);

            Console.WriteLine(bla);

            Rectangle rec = new Rectangle(new Point(34, 3), new Point(74, 44), new Point(24, 13), new Point(23, 50));

            ShapeHolder sHolder = new ShapeHolder();
            sHolder.AddShape(c);
            sHolder.AddShape(bla);
            sHolder.AddShape(rec);

            Console.WriteLine("print sHolder - original list of shapes");
            Console.WriteLine(sHolder.ToString());

            ShapeHolder sHolderClone = sHolder.clone();
            Console.WriteLine(sHolderClone.ToString());

        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }
    }
}
