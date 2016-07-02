using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Ellipse:Shape,IPersist, IComparable
    {
        public int Width { get { return _mWidth; } }
        public int Height { get { return _mHeight; } }

        private int _mWidth;
        private int _mHeight;

        public Ellipse(int width, int height, ConsoleColor color):base(color)
        {
            _mWidth = width;
            _mHeight = height;
        }

        public Ellipse(int width, int height):base()
        {
            _mWidth = width;
            _mHeight = height;
        }
        public override double Area
        {
            get { return GetArea(); }
        }

        private double GetArea()
        {
            return _mWidth * _mHeight*Math.PI;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Ellipse got width: {0} and height: {1}",this._mWidth,this._mHeight);
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine(string.Format("{0} - Width: {1} height: {2}", this.GetType(), this._mWidth, this._mHeight));
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Ellipse other = obj as Ellipse;
            if (other != null)
                return this.Area.CompareTo(other.Area);
            else
                throw new ArgumentException("Object is not a Ellipse");
        }
    }
}
