using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite(12);
                Component leftChild = new Leaf(14);
                Component rightChild = new Composite(36);
                Component leftChildOfRightChild = new Leaf(66);
                Component rightChildOfRightChild = new Leaf(1888);
                rightChild.AddChild(leftChildOfRightChild);
                rightChild.AddChild(rightChildOfRightChild);
                root.AddChild(leftChild);
                root.AddChild(rightChild);
                
                Console.WriteLine($"The Tree sum is: {root.Sum()} ");
                Console.WriteLine($"Does all tree is even? {root.IsEven()}");

                root.Draw("");

        }

        public bool IsEven(Component biNonde)
        {
                return biNonde.IsEven();
        }
     }
}
