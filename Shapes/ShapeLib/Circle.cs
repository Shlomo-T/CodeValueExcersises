using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle:Ellipse
    {
        public int Radius {get { return _mRadius; } }
        private int _mRadius;
        public Circle(int radius, ConsoleColor color) : base(radius, radius, color)
        {
            _mRadius = radius;
        }

        public Circle(int radius) : base(radius, radius)
        {
            _mRadius = radius;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Circle got radius: {0}", this._mRadius);

        }
    }
}
