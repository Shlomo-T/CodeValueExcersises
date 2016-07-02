using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager mgr= new ShapeManager();
            mgr.Add(new Circle(5));
            mgr.Add(new Ellipse(3,4,ConsoleColor.Blue));
            mgr.Add(new Rectangle(3,4,ConsoleColor.DarkYellow));
            mgr.Add(new Circle(5,ConsoleColor.Red));


            mgr.DisplayAll();
            StringBuilder sb = new StringBuilder("Log:\n");
            mgr.Save(sb);
            Console.WriteLine(sb.ToString());

            Rectangle rec = new Rectangle(5,8);
            Rectangle otherRec=new Rectangle(2,3);

            rec.Display();
            otherRec.Display();

            
            Console.ReadKey();
        }
    }
}
