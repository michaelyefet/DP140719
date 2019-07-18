using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_EX20
{
    class MergeSort : ISort
    {
        public void sort(List<int> numbers)
        {
            Console.WriteLine("sorting by mergeSort");
        }
    }
}
