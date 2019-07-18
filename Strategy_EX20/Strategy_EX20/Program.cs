using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_EX20
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection NumCollec = new NumberCollection();
            NumCollec.Add(5);
            NumCollec.Add(7);
            NumCollec.Add(3);

            NumCollec.Sort();

            NumCollec.Add(2);
            NumCollec.Add(98);
            NumCollec.Add(45);

            NumCollec.Sort();

            NumCollec.Remove(5);
        }
    }
}
