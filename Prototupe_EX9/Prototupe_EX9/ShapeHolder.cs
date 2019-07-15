using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototupe_EX9
{
    class ShapeHolder : IProtoType<ShapeHolder>
    {
        private List<Shape> ShapeList = new List<Shape>();

        public void AddShape(Shape ToAdd)
        {
            this.ShapeList.Add(ToAdd);
        }

        public void RemoveShape(Shape ToRemove)
        {
            this.ShapeList.Remove(ToRemove);
        }

        public override string ToString()
        {
            string str = "list of shapes:\n";
            foreach (Shape sh in this.ShapeList)
            {
                str += sh.ToString() + "\n";
            }
            return str;
        }

        public ShapeHolder clone()
        {
            ShapeHolder ShapeListClone = new ShapeHolder();
            foreach (Shape sh in this.ShapeList)
            {
                ShapeListClone.AddShape(sh.clone());
            }
            return ShapeListClone;
        }
    }
}
