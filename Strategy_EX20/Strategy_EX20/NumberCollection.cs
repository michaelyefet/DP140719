using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_EX20
{
    class NumberCollection
    {
        private const int MaxForMerge = 5;
        protected List<int> numbers = new List<int>();
        protected ISort SortType;

        public NumberCollection()
        {
            this.SortType = new MergeSort();
        }

        public void Add(int NumToAdd)
        {
            this.numbers.Add(NumToAdd);
            if(this.numbers.Count > 5)
            {
                this.SortType = new QuickSort();
            }
        }

        public void Remove(int NumToRemove)
        {
            this.numbers.Remove(NumToRemove);
            if (this.numbers.Count < 5)
            {
                this.SortType = new MergeSort();
            }
        }

        public void Sort()
        {
            this.SortType.sort(this.numbers);
        }
    }
}
