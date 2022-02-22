using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\lawre\Desktop\Coding\c#\c#-basics-beginners\section-6-arrays-lists\Arrays\ArraysAndLists.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extensions: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
