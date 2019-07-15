using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototupe_EX9
{
    class Rectangle : Shape
    {

        public Point TopLeft { get; set; }
        public Point TopRight { get; set; }
        public Point DownLeft { get; set; }
        public Point DownRight { get; set; }

        public Rectangle(Point TopLeft, Point TopRight, Point DownLeft, Point DownRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.DownLeft = DownLeft;
            this.DownRight = DownRight;
        }

        public override string ToString()
        {
            return $"Rectangle Points: {TopLeft} {TopRight} {DownLeft} {DownRight}";
        }

        public override Shape clone()
        {
            return new Rectangle((Point)TopLeft.clone(), (Point)TopRight.clone(), (Point)DownLeft.clone(), (Point)DownRight.clone());
        }
    }
}
