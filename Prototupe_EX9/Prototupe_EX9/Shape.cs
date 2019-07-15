using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototupe_EX9
{
    public abstract class Shape : IProtoType<Shape>
    {
        public abstract Shape clone();
    }
}
