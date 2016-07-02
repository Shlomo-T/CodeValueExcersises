using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class Program
    {
        static void Main(string[] args)
        {
             Helper helper= new Helper();
            string dirPath=null, subString=null;
            if (helper.CheckArgs(args))
            {
                dirPath = args[0];
                subString = args[1];
            }

            if (!string.IsNullOrEmpty(dirPath) && !string.IsNullOrEmpty(subString))
            {
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                if (dir.Exists)
                {
                    //
                    var fileList = dir.GetFiles("*.*");
                    var dirList = dir.GetDirectories("*.*");
                    List<FileInfo> ans = new List<FileInfo>();

                    // startpoint of recursion
                    helper.SearchForFilesrecursively(dirList, fileList, ans, subString);

                    if (ans != null && ans.Any())
                    {
                        foreach (var file in ans)
                        {
                            Console.WriteLine($"File:{file} File Length:{file.Length}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Unexpected parameters...");
            }
            Console.ReadKey();
        }
    }
}
