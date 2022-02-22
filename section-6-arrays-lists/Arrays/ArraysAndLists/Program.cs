using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            var numbers = new int[] { 3, 6, 7, 2, 14 };
            //Arrays.displayNumArray(numbers);

            // Length
            Console.WriteLine(String.Format("Length: {0}", numbers.Length));

            // IndexOf()
            int index = Array.IndexOf(numbers, 2);
            Console.WriteLine(String.Format("Index of {0}: {1}", 2, index));

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (int n in numbers)
                Console.WriteLine(n);

            // Copy
            var numbers2 = new int[3];
            Array.Copy(numbers, numbers2, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (int n in numbers2)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Copy()");
            foreach(int n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);
            foreach(int n in numbers)
                Console.WriteLine(n);
        }
    }
}
