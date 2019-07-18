using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX02
{
    public class Composite : Component
    {

        IList<Component> childs = new List<Component>();

        public Composite(int num) : base(num)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.Number);
            foreach (Component c in childs)
            {
                c.Draw(space + "    ");
            }
        }

        public override int Sum()
        {
            int sum = this.Number;
            foreach (Component currComponent in childs)
            {
                sum += currComponent.Sum();
            }
            return sum;
        }

        public override bool IsEven()
        {
           if (this.Number % 2 == 1)
           {
               return false;
           }
           else
           {
               bool currEven = true;
               foreach (Component currComponent in this.GetChilds())
               {
                   currEven = currEven && currComponent.IsEven();
               }
               return currEven;
           }
        }
    }
}
