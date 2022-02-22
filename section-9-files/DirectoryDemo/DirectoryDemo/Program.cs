using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Directory
            Directory.CreateDirectory(@"C:\Users\lawre\Desktop\Coding\c#\c#-basics-beginners\section-8-text\new");
            // Gets all the files ending with .sln
            var files = Directory.GetFiles(@"C:\Users\lawre\Desktop\Coding\c#\c#-basics-beginners\section-8-text", "*.sln", SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Users\lawre\Desktop\Coding\c#\c#-basics-beginners\section-8-text", "*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            // Directory Info
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
