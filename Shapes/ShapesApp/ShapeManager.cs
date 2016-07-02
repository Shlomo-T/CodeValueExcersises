using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib;

namespace ShapesApp
{
    public class ShapeManager
    {
        public int Count { get { return shapes.Count; } }
        private ArrayList shapes;

        public ShapeManager()
        {
            shapes= new ArrayList();
        }
        public void Add(Shape shape)
        {
            if (shape != null)
            {
                shapes.Add(shape);
            }
        }

        public void DisplayAll()
        {
            //displaying all shapes

            if (shapes != null && shapes.Count>0)
            {
                foreach (Shape shape in shapes)
                {
                    shape.Display();
                    Console.WriteLine("The area is {0}",shape.Area);
                }
            }
        }

        public Shape this[int index]
        {
            get { return (Shape)shapes[index]; }
        }

        public void Save(StringBuilder sb)
        {
            //logging data to string builder

            if (shapes != null && shapes.Count > 0)
            {
                foreach (IPersist shape in shapes)
                {
                    shape.Write(sb);
                }
            }
        }
    }
}
