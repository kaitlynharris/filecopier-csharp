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

            var fileRetriever = new FileRetriever();

            var filesToCopy = fileRetriever.GetFilesToCopy(source);

            var copier = new Copier();

            copier.CopyFiles(filesToCopy, source, dest);

            Console.ReadKey();

        }
    }
}
