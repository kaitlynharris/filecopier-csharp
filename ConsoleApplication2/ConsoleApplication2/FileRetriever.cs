using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FileRetriever
    {
        internal string[] GetFilesToCopy(string fromDirectory)
        {
            string[] fileArray = System.IO.Directory.GetFiles(fromDirectory);
            return fileArray;
        }
    }
}
