using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Copier
    {
        internal void CopyFiles(string[] fileArray, string sourcePath, string destPath)
        {
            foreach (string file in fileArray)
            {
                var name = System.IO.Path.GetFileName(file);
                var source = System.IO.Path.Combine(sourcePath, name);
                var destination = System.IO.Path.Combine(destPath, name);
                var oneDayAgo = DateTime.Now.AddDays(-1);
                if (System.IO.File.GetLastWriteTime(source) > oneDayAgo)
                {
                    System.IO.File.Copy(file, destination, true);
                }
            }
        }
    }
}
