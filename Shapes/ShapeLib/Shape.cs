using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Shape
    {
        public ConsoleColor Color { get { return _mColor; } }
        private ConsoleColor _mColor;

        public abstract double Area { get; }
        public Shape(ConsoleColor color)
        {
            this._mColor = color;
        }
        public Shape()
        {
            this._mColor = ConsoleColor.White;
        }

        public virtual void Display()
        {
            Console.ForegroundColor = _mColor;
        }
    }
}
