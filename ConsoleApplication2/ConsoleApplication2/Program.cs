using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //change these to specify different to/from directories
            string source = @"C:\C#Projects\SourceFolder";
            string dest = @"C:\C#Projects\DestFolder";

            var FileRetriever = new FileRetriever();

            var filesToCopy = FileRetriever.GetFilesToCopy(source);

            var Copier = new Copier();

            Copier.CopyFiles(filesToCopy, source, dest);

            Console.ReadKey();

        }
    }
}
