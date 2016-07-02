using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper= new Helper();
            string path = helper.GetFilePath();
            StreamReader reader= new StreamReader(path);
            string[] Names = helper.ReadFromFile(reader);

            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
