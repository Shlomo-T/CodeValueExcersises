using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    public class Helper
    {
        public string GetFilePath()
        {
            // File could be in every path that we want
            string path = ConfigurationManager.AppSettings["FilePath"];
            return path;
        }
        
        public string[] ReadFromFile(StreamReader reader)
        {
            // if there's a line to read the reader will make sure to read it
            List<string> comp = new List<string>();
            while (reader.Peek() >= 0)
            {
                string name = reader.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    comp.Add(name);
                }
            }
            return comp.ToArray();
        }
    }
}
