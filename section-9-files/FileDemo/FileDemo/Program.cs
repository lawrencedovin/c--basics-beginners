using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File: instance
            var path = @"C:\Users\lawre\Desktop\Coding\c#\c#-basics-beginners\section-7-dates\copy-me.txt";
            File.Copy(@"C:\Users\lawre\Desktop\Coding\c#\c#-basics-beginners\section-7-dates\copy-me.txt",
                      @"C:\Users\lawre\Desktop\Coding\c#\c#-basics-beginners\section-8-text\copy-me.txt", true);
            // File.Delete(path);
            if(File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);
            Console.WriteLine(content);

            // FileInfo: static
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //
            }
            fileInfo.OpenRead();
        }
    }
}
