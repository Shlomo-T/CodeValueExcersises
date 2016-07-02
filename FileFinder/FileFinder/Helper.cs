using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace FileFinder
{
    public class Helper
    {
        public bool CheckArgs(string[] args)
        {
            if (args != null && args.Length >= 2 && !string.IsNullOrEmpty(args[0]) && !string.IsNullOrEmpty(args[1]))
            {
                return true;
            }
            return false;
        }

        public void SearchForFilesrecursively(ICollection<DirectoryInfo> dirs, ICollection<FileInfo> files,
            List<FileInfo> ans,string subString)
        {
            if ((files == null || !files.Any()) && (dirs == null || !dirs.Any()))
            {
                return;
            }

            if (files != null && files.Any())
            {
                foreach (var file in files)
                {
                    if (file != null && !string.IsNullOrEmpty(file.Name) && file.Name.Contains(subString))
                    {
                        ans.Add(file);
                    }
                }
            }

            if (dirs != null && dirs.Any())
            {
                foreach (var dir in dirs)
                {
                    if (dir!=null)
                    {
                        var fileList = dir.GetFiles("*.*");
                        var dirList = dir.GetDirectories("*.*");
                        SearchForFilesrecursively(dirList, fileList, ans,subString);
                    }
                }
            }
        }
    }
}
