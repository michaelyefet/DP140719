using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX02
{
    public class Leaf :  Component
    {
        public Leaf(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            throw new NotSupportedException("Leaf element can't have children!");
        }

        public override IList<Component> GetChilds()
        {
            return null;
        }

        public override void RemoveChild(Component c)
        {
            throw new NotSupportedException("Leaf element doesn't have children!");
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.Number);
        }

        public override int Sum()
        {
            return this.Number;
        }

        public override bool IsEven()
        {
            if(this.Number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
